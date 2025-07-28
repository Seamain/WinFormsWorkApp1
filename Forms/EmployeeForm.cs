using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WinFormsWorkApp1.Helpers;
using WinFormsWorkApp1.Models;

namespace WinFormsWorkApp1.Forms
{
    public partial class EmployeeForm : Form
    {
        private NursingHomeDbContext dbContext;
        private int currentEmployeeId = 0;

        public EmployeeForm()
        {
            InitializeComponent();
            dbContext = new NursingHomeDbContext();
            InitializeData();
        }

        private void InitializeData()
        {
            LoadEmployees();
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            // 设置默认值
            cmbGender.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            cmbSearchStatus.SelectedIndex = 0;

            dtpBirthDate.Value = DateTime.Now.AddYears(-30);
            dtpHireDate.Value = DateTime.Now;
        }

        private void LoadEmployees()
        {
            try
            {
                var employees = dbContext.Employees
                    .OrderBy(e => e.Name)
                    .ToList();

                dgvEmployees.DataSource = employees;
                ConfigureEmployeeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载员工数据失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureEmployeeDataGridView()
        {
            if (dgvEmployees.Columns.Count > 0)
            {
                dgvEmployees.Columns["Id"].HeaderText = "编号";
                dgvEmployees.Columns["Name"].HeaderText = "姓名";
                dgvEmployees.Columns["IdCard"].HeaderText = "身份证号";
                dgvEmployees.Columns["Gender"].HeaderText = "性别";
                dgvEmployees.Columns["BirthDate"].HeaderText = "出生日期";
                dgvEmployees.Columns["Phone"].HeaderText = "联系电话";
                dgvEmployees.Columns["Position"].HeaderText = "职位";
                dgvEmployees.Columns["Department"].HeaderText = "部门";
                dgvEmployees.Columns["Status"].HeaderText = "状态";
                dgvEmployees.Columns["HireDate"].HeaderText = "入职日期";

                // 隐藏不需要显示的列
                if (dgvEmployees.Columns["Address"] != null)
                    dgvEmployees.Columns["Address"].Visible = false;
                if (dgvEmployees.Columns["EmergencyContact"] != null)
                    dgvEmployees.Columns["EmergencyContact"].Visible = false;
                if (dgvEmployees.Columns["EmergencyPhone"] != null)
                    dgvEmployees.Columns["EmergencyPhone"].Visible = false;
                if (dgvEmployees.Columns["Notes"] != null)
                    dgvEmployees.Columns["Notes"].Visible = false;
                if (dgvEmployees.Columns["CreateTime"] != null)
                    dgvEmployees.Columns["CreateTime"].Visible = false;

                // 设置日期格式
                if (dgvEmployees.Columns["BirthDate"] != null)
                    dgvEmployees.Columns["BirthDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                if (dgvEmployees.Columns["HireDate"] != null)
                    dgvEmployees.Columns["HireDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
        }

        // 员工信息事件处理
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateEmployeeInput())
                    return;

                var employee = new Employee
                {
                    Name = txtName.Text.Trim(),
                    IdCard = txtIdCard.Text.Trim(),
                    Gender = cmbGender.Text,
                    BirthDate = dtpBirthDate.Value.Date,
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    EmergencyContact = txtEmergencyContact.Text.Trim(),
                    EmergencyPhone = txtEmergencyPhone.Text.Trim(),
                    Position = cmbPosition.Text,
                    Department = cmbDepartment.Text,
                    HireDate = dtpHireDate.Value.Date,
                    Status = cmbStatus.Text,
                    Notes = txtNotes.Text.Trim(),
                    CreateTime = DateTime.Now
                };

                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();

                MessageBox.Show("员工信息添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEmployeeForm();
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加员工信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentEmployeeId == 0)
                {
                    MessageBox.Show("请先选择要修改的员工！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateEmployeeInput())
                    return;

                var employee = dbContext.Employees.Find(currentEmployeeId);
                if (employee == null)
                {
                    MessageBox.Show("员工信息不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                employee.Name = txtName.Text.Trim();
                employee.IdCard = txtIdCard.Text.Trim();
                employee.Gender = cmbGender.Text;
                employee.BirthDate = dtpBirthDate.Value.Date;
                employee.Phone = txtPhone.Text.Trim();
                employee.Address = txtAddress.Text.Trim();
                employee.EmergencyContact = txtEmergencyContact.Text.Trim();
                employee.EmergencyPhone = txtEmergencyPhone.Text.Trim();
                employee.Position = cmbPosition.Text;
                employee.Department = cmbDepartment.Text;
                employee.HireDate = dtpHireDate.Value.Date;
                employee.Status = cmbStatus.Text;
                employee.Notes = txtNotes.Text.Trim();

                dbContext.SaveChanges();

                MessageBox.Show("员工信息修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEmployeeForm();
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改员工信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentEmployeeId == 0)
                {
                    MessageBox.Show("请先选择要删除的员工！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("确定要删除这个员工信息吗？", "确认删除",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var employee = dbContext.Employees.Find(currentEmployeeId);
                    if (employee != null)
                    {
                        dbContext.Employees.Remove(employee);
                        dbContext.SaveChanges();

                        MessageBox.Show("员工信息删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearEmployeeForm();
                        LoadEmployees();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除员工信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEmployeeForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var query = dbContext.Employees.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtSearchName.Text))
                {
                    query = query.Where(e => e.Name.Contains(txtSearchName.Text.Trim()));
                }

                if (!string.IsNullOrWhiteSpace(txtSearchIdCard.Text))
                {
                    query = query.Where(e => e.IdCard.Contains(txtSearchIdCard.Text.Trim()));
                }

                if (cmbSearchStatus.SelectedIndex > 0)
                {
                    query = query.Where(e => e.Status == cmbSearchStatus.Text);
                }

                var employees = query.OrderBy(e => e.Name).ToList();
                dgvEmployees.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                var employee = (Employee)dgvEmployees.CurrentRow.DataBoundItem;
                if (employee != null)
                {
                    LoadEmployeeToForm(employee);
                }
            }
        }

        private bool ValidateEmployeeInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("请输入员工姓名！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIdCard.Text))
            {
                MessageBox.Show("请输入身份证号！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdCard.Focus();
                return false;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("请选择性别！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return false;
            }

            // 验证身份证号格式
            if (txtIdCard.Text.Trim().Length != 18)
            {
                MessageBox.Show("身份证号必须是18位！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdCard.Focus();
                return false;
            }

            // 验证手机号格式
            if (!string.IsNullOrWhiteSpace(txtPhone.Text) && txtPhone.Text.Trim().Length != 11)
            {
                MessageBox.Show("手机号必须是11位！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            return true;
        }

        private void LoadEmployeeToForm(Employee employee)
        {
            currentEmployeeId = employee.Id;
            txtName.Text = employee.Name ?? "";
            txtIdCard.Text = employee.IdCard ?? "";
            cmbGender.Text = employee.Gender ?? "";
            dtpBirthDate.Value = employee.BirthDate ?? DateTime.Now.AddYears(-30);
            txtPhone.Text = employee.Phone ?? "";
            txtAddress.Text = employee.Address ?? "";
            txtEmergencyContact.Text = employee.EmergencyContact ?? "";
            txtEmergencyPhone.Text = employee.EmergencyPhone ?? "";
            cmbPosition.Text = employee.Position ?? "";
            cmbDepartment.Text = employee.Department ?? "";
            dtpHireDate.Value = employee.HireDate;
            cmbStatus.Text = employee.Status ?? "";
            txtNotes.Text = employee.Notes ?? "";
        }

        private void ClearEmployeeForm()
        {
            currentEmployeeId = 0;
            txtName.Clear();
            txtIdCard.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmergencyContact.Clear();
            txtEmergencyPhone.Clear();
            txtNotes.Clear();

            cmbGender.SelectedIndex = 0;
            cmbPosition.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            cmbStatus.SelectedIndex = 0;

            dtpBirthDate.Value = DateTime.Now.AddYears(-30);
            dtpHireDate.Value = DateTime.Now;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                dbContext?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}