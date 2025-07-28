using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WinFormsWorkApp1.Helpers;
using WinFormsWorkApp1.Models;

namespace WinFormsWorkApp1.Forms
{
    public partial class LoginForm : Form
    {
        private NursingHomeDbContext _context;
        private bool _isRegisterMode = false; public LoginForm()
        {
            InitializeComponent();
            _context = new NursingHomeDbContext();

            // 初始化性别下拉框默认值
            if (cmbGender.Items.Count > 0)
            {
                cmbGender.SelectedIndex = 0;
            }

            InitializeAsync();
        }
        private async void InitializeAsync()
        {
            try
            {
                // 添加数据库连接诊断
                await DiagnoseDatabaseConnection();
                await _context.Database.EnsureCreatedAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据库初始化失败：{ex.Message}\n\n详细信息：{ex.InnerException?.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DiagnoseDatabaseConnection()
        {
            try
            {
                // 获取数据库连接字符串用于诊断
                var connection = _context.Database.GetDbConnection();
                string connectionString = connection.ConnectionString;

                // 提取数据源路径
                string dataSource = "未知";
                if (connectionString.Contains("Data Source="))
                {
                    int startIndex = connectionString.IndexOf("Data Source=") + "Data Source=".Length;
                    int endIndex = connectionString.IndexOf(";", startIndex);
                    if (endIndex == -1) endIndex = connectionString.Length;
                    dataSource = connectionString.Substring(startIndex, endIndex - startIndex);
                }

                // 诊断信息
                string diagnosticInfo = $"数据库连接诊断信息：\n" +
                                      $"当前工作目录：{Environment.CurrentDirectory}\n" +
                                      $"应用程序基目录：{AppDomain.CurrentDomain.BaseDirectory}\n" +
                                      $"数据库文件路径：{dataSource}\n" +
                                      $"数据库文件是否存在：{File.Exists(dataSource)}";

                // 在Debug模式下显示诊断信息
#if DEBUG
                Console.WriteLine(diagnosticInfo);
#endif

                // 测试数据库连接
                await connection.OpenAsync();
                await connection.CloseAsync();
            }
            catch (Exception ex)
            {
                string errorInfo = $"数据库连接诊断失败：{ex.Message}";
#if DEBUG
                Console.WriteLine(errorInfo);
#endif
                throw;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (_isRegisterMode)
            {
                await RegisterAsync();
            }
            else
            {
                await LoginAsync();
            }
        }
        private async Task LoginAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("请输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text; // 直接使用明文密码

                // 使用更简单的方法 - 避免Access数据库参数问题
                List<Employee> allEmployees;

                try
                {
                    // 先检查是否有员工
                    var hasEmployees = await _context.Employees.AnyAsync();
                    if (!hasEmployees)
                    {
                        MessageBox.Show("数据库中没有用户，请先注册", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // 获取所有员工记录
                    allEmployees = await _context.Employees.ToListAsync();
                }
                catch (Exception dbEx)
                {
                    MessageBox.Show($"数据库连接错误：{dbEx.Message}", "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                // 在内存中查找用户，避免参数化查询问题
                var user = allEmployees.FirstOrDefault(e =>
                    !string.IsNullOrEmpty(e.Username) &&
                    !string.IsNullOrEmpty(e.Password) &&
                    string.Equals(e.Username.Trim(), username, StringComparison.OrdinalIgnoreCase) &&
                    e.Password == password); // 直接比较明文密码

                if (user != null)
                {
                    MessageBox.Show($"登录成功！欢迎 {user.Name}", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx)
            {
                MessageBox.Show($"数据库更新错误：{dbEx.Message}\n\n内部异常：{dbEx.InnerException?.Message}", "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.Common.DbException dbEx)
            {
                MessageBox.Show($"数据库查询错误：{dbEx.Message}\n\n详细信息：{dbEx}", "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"登录失败：{ex.Message}\n\n异常类型：{ex.GetType().Name}\n\n堆栈跟踪：{ex.StackTrace}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RegisterAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("请输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                if (txtPassword.Text.Length < 6)
                {
                    MessageBox.Show("密码长度至少6位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("请输入姓名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }                // 检查用户名是否已存在 - 使用简单查询避免参数问题
                var allExistingEmployees = await _context.Employees.ToListAsync();
                var existingUser = allExistingEmployees.FirstOrDefault(e =>
                    !string.IsNullOrEmpty(e.Username) &&
                    string.Equals(e.Username.Trim(), txtUsername.Text.Trim(), StringComparison.OrdinalIgnoreCase));

                if (existingUser != null)
                {
                    MessageBox.Show("用户名已存在，请选择其他用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }                // 创建新用户 - 确保所有必需字段都有值
                var newEmployee = new Employee
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text, // 直接存储明文密码
                    Name = txtName.Text.Trim(),
                    IdCard = "000000000000000000", // 必需字段
                    Gender = string.IsNullOrEmpty(cmbGender.Text) ? "男" : cmbGender.Text.Trim(),
                    BirthDate = DateTime.Now.AddYears(-30), // 默认30岁
                    Age = 30, // 设置年龄
                    Phone = string.IsNullOrEmpty(txtPhone.Text) ? "00000000000" : txtPhone.Text.Trim(),
                    Address = "未填写",
                    EmergencyContact = "未填写",
                    EmergencyPhone = "00000000000",
                    Position = "普通员工", // 必需字段
                    Department = "系统用户",
                    HireDate = DateTime.Now,
                    Status = "在职",
                    Notes = "系统注册用户",
                    CreateTime = DateTime.Now,
                    UpdateTime = null // 可为空的DateTime字段
                };

                _context.Employees.Add(newEmployee);
                await _context.SaveChangesAsync();

                MessageBox.Show("注册成功！请登录", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 切换到登录模式
                SwitchToLoginMode();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException dbEx)
            {
                // 处理数据库更新异常
                string dbError = $"数据库更新失败：{dbEx.Message}";
                if (dbEx.InnerException != null)
                {
                    dbError += $"\n内部错误：{dbEx.InnerException.Message}";
                    if (dbEx.InnerException.InnerException != null)
                    {
                        dbError += $"\n具体错误：{dbEx.InnerException.InnerException.Message}";
                    }
                }
                MessageBox.Show(dbError, "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.Common.DbException dbEx)
            {
                // 处理通用数据库异常
                string dbError = $"数据库操作失败：{dbEx.Message}";
                if (dbEx.InnerException != null)
                {
                    dbError += $"\n内部错误：{dbEx.InnerException.Message}";
                }
                MessageBox.Show(dbError, "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // 提供更详细的错误信息用于调试
                string detailedError = $"注册失败：{ex.Message}";
                if (ex.InnerException != null)
                {
                    detailedError += $"\n内部错误：{ex.InnerException.Message}";
                }
                if (ex.StackTrace != null)
                {
                    detailedError += $"\n堆栈跟踪：{ex.StackTrace}";
                }

                MessageBox.Show(detailedError, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkSwitchMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_isRegisterMode)
            {
                SwitchToLoginMode();
            }
            else
            {
                SwitchToRegisterMode();
            }
        }
        private void SwitchToLoginMode()
        {
            _isRegisterMode = false;
            this.Text = "用户登录 - 养老院管理系统";
            lblTitle.Text = "用户登录";
            btnLogin.Text = "登录";
            lnkSwitchMode.Text = "没有账号？点击注册";

            // 隐藏注册相关控件
            lblName.Visible = false;
            txtName.Visible = false;
            lblGender.Visible = false;
            cmbGender.Visible = false;
            lblPhone.Visible = false;
            txtPhone.Visible = false;

            // 调整按钮和链接位置（登录模式）
            btnLogin.Location = new System.Drawing.Point(120, 160);
            lnkSwitchMode.Location = new System.Drawing.Point(150, 210);

            // 调整窗体大小
            this.Height = 280;

            ClearForm();
        }
        private void SwitchToRegisterMode()
        {
            _isRegisterMode = true;
            this.Text = "用户注册 - 养老院管理系统";
            lblTitle.Text = "用户注册";
            btnLogin.Text = "注册";
            lnkSwitchMode.Text = "已有账号？点击登录";

            // 显示注册相关控件
            lblName.Visible = true;
            txtName.Visible = true;
            lblGender.Visible = true;
            cmbGender.Visible = true;
            lblPhone.Visible = true;
            txtPhone.Visible = true;

            // 调整按钮和链接位置（注册模式下移动到电话框下方）
            btnLogin.Location = new System.Drawing.Point(120, 260);
            lnkSwitchMode.Location = new System.Drawing.Point(150, 310);

            // 调整窗体大小
            this.Height = 380;

            ClearForm();
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtPhone.Clear();
            if (cmbGender.Items.Count > 0)
                cmbGender.SelectedIndex = 0;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                _context?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
