using Microsoft.EntityFrameworkCore;
using WinFormsWorkApp1.Helpers;
using WinFormsWorkApp1.Models;

namespace WinFormsWorkApp1.Forms
{
    public partial class DailyLifeForm : Form
    {
        private NursingHomeDbContext _context;
        private BindingSource _outingBindingSource;
        private BindingSource _mealBindingSource;
        private BindingSource _careRecordBindingSource;
        private BindingSource _carePackageBindingSource;
        private BindingSource _residentBindingSource;

        public DailyLifeForm()
        {
            InitializeComponent();
            _context = new NursingHomeDbContext();
            _outingBindingSource = new BindingSource();
            _mealBindingSource = new BindingSource();
            _careRecordBindingSource = new BindingSource();
            _carePackageBindingSource = new BindingSource();
            _residentBindingSource = new BindingSource();

            InitializeData();
        }

        private async void InitializeData()
        {
            try
            {
                await _context.Database.EnsureCreatedAsync();
                await LoadDataAsync();
                SetupDataBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"初始化数据失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadDataAsync()
        {
            // 加载老人信息 - 支持多种状态
            var residents = await _context.Residents
                .Where(r => r.Status == "在住" || r.Status == "已入住")
                .OrderBy(r => r.Name)
                .ToListAsync();
            _residentBindingSource.DataSource = residents;

            // 如果没有找到"在住"或"已入住"状态的住户，尝试加载所有住户
            if (!residents.Any())
            {
                var allResidents = await _context.Residents.OrderBy(r => r.Name).ToListAsync();
                _residentBindingSource.DataSource = allResidents;

                // 记录调试信息
                if (allResidents.Any())
                {
                    var statusList = allResidents.Select(r => r.Status).Distinct().ToList();
                    MessageBox.Show($"警告：未找到'在住'或'已入住'状态的住户。\n" +
                                  $"已加载所有 {allResidents.Count} 位住户。\n" +
                                  $"现有状态：{string.Join(", ", statusList)}",
                                  "数据加载提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("数据库中没有住户记录，请先添加住户数据。",
                                  "数据为空", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // 加载外出记录
            var outingRecords = await _context.OutingRecords
                .Include(o => o.Resident)
                .OrderByDescending(o => o.OutTime)
                .ToListAsync();
            _outingBindingSource.DataSource = outingRecords;

            // 加载餐饮记录
            var mealRecords = await _context.MealRecords
                .Include(m => m.Resident)
                .Where(m => m.MealDate >= DateTime.Today.AddDays(-7))
                .OrderByDescending(m => m.MealDate)
                .ToListAsync();
            _mealBindingSource.DataSource = mealRecords;

            // 加载护理记录
            var careRecords = await _context.CareRecords
                .Include(c => c.Resident)
                .Include(c => c.CarePackage)
                .Where(c => c.CareDate >= DateTime.Today.AddDays(-30))
                .OrderByDescending(c => c.CareDate)
                .ToListAsync();
            _careRecordBindingSource.DataSource = careRecords;

            // 加载护理套餐
            var carePackages = await _context.CarePackages
                .Where(p => p.IsActive)
                .OrderBy(p => p.PackageName)
                .ToListAsync();
            _carePackageBindingSource.DataSource = carePackages;
        }

        private void SetupDataBinding()
        {            // 外出管理
            dgvOuting.DataSource = _outingBindingSource;
            ConfigureOutingGrid();
            cmbOutingResident.DataSource = _residentBindingSource;
            cmbOutingResident.DisplayMember = "Name";
            cmbOutingResident.ValueMember = "Id";

            // 餐饮管理
            dgvMeals.DataSource = _mealBindingSource;
            ConfigureMealsGrid();
            cmbMealResident.DataSource = _residentBindingSource;
            cmbMealResident.DisplayMember = "Name";
            cmbMealResident.ValueMember = "Id";

            // 护理管理
            dgvCareRecords.DataSource = _careRecordBindingSource;
            ConfigureCareRecordsGrid();
            cmbCareResident.DataSource = _residentBindingSource;
            cmbCareResident.DisplayMember = "Name";
            cmbCareResident.ValueMember = "Id";

            cmbCarePackage.DataSource = _carePackageBindingSource;
            cmbCarePackage.DisplayMember = "PackageName";
            cmbCarePackage.ValueMember = "Id";
        }

        // 外出记录管理
        private async void btnAddOuting_Click(object sender, EventArgs e)
        {
            if (!ValidateOutingInput()) return;

            try
            {
                var outingRecord = new OutingRecord
                {
                    ResidentId = (int)cmbOutingResident.SelectedValue,
                    Destination = txtDestination.Text.Trim(),
                    Purpose = txtPurpose.Text.Trim(),
                    OutTime = dtpOutTime.Value,
                    Companion = txtCompanion.Text.Trim(),
                    CompanionPhone = txtCompanionPhone.Text.Trim(),
                    Status = "外出中",
                    Notes = txtOutingNotes.Text.Trim(),
                    CreatedBy = "系统管理员"
                };

                _context.OutingRecords.Add(outingRecord);
                await _context.SaveChangesAsync();
                await LoadDataAsync();
                ClearOutingForm();
                MessageBox.Show("外出记录添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加外出记录失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnReturnOuting_Click(object sender, EventArgs e)
        {
            if (dgvOuting.CurrentRow?.DataBoundItem is OutingRecord selectedRecord)
            {
                if (selectedRecord.Status == "已返回")
                {
                    MessageBox.Show("该记录已标记为返回！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    selectedRecord.Status = "已返回";
                    selectedRecord.ReturnTime = DateTime.Now;
                    await _context.SaveChangesAsync();
                    await LoadDataAsync();
                    MessageBox.Show("返回记录更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"更新返回记录失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 餐饮记录管理
        private async void btnAddMeal_Click(object sender, EventArgs e)
        {
            if (!ValidateMealInput()) return;

            try
            {
                var mealRecord = new MealRecord
                {
                    ResidentId = (int)cmbMealResident.SelectedValue,
                    MealDate = dtpMealDate.Value,
                    MealType = cmbMealType.Text,
                    MenuItems = txtMenuItems.Text.Trim(),
                    Appetite = cmbAppetite.Text,
                    SpecialDiet = txtSpecialDiet.Text.Trim(),
                    Notes = txtMealNotes.Text.Trim(),
                    CreatedBy = "系统管理员"
                };

                _context.MealRecords.Add(mealRecord);
                await _context.SaveChangesAsync();
                await LoadDataAsync();
                ClearMealForm();
                MessageBox.Show("餐饮记录添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加餐饮记录失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 护理记录管理
        private async void btnAddCareRecord_Click(object sender, EventArgs e)
        {
            if (!ValidateCareInput()) return;

            try
            {
                var careRecord = new CareRecord
                {
                    ResidentId = (int)cmbCareResident.SelectedValue,
                    CarePackageId = cmbCarePackage.SelectedValue as int?,
                    CareDate = dtpCareDate.Value,
                    CareType = cmbCareType.Text,
                    CareContent = txtCareContent.Text.Trim(),
                    CareResult = cmbCareResult.Text,
                    Notes = txtCareNotes.Text.Trim(),
                    CaregiverName = txtCaregiverName.Text.Trim()
                };

                _context.CareRecords.Add(careRecord);
                await _context.SaveChangesAsync();
                await LoadDataAsync();
                ClearCareForm();
                MessageBox.Show("护理记录添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加护理记录失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 验证方法
        private bool ValidateOutingInput()
        {
            if (cmbOutingResident.SelectedValue == null)
            {
                MessageBox.Show("请选择老人！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("请输入外出目的地！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidateMealInput()
        {
            if (cmbMealResident.SelectedValue == null)
            {
                MessageBox.Show("请选择老人！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbMealType.Text))
            {
                MessageBox.Show("请选择用餐类型！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidateCareInput()
        {
            if (cmbCareResident.SelectedValue == null)
            {
                MessageBox.Show("请选择老人！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbCareType.Text))
            {
                MessageBox.Show("请选择护理类型！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCaregiverName.Text))
            {
                MessageBox.Show("请输入护理员姓名！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 清空表单方法
        private void ClearOutingForm()
        {
            cmbOutingResident.SelectedIndex = -1;
            txtDestination.Clear();
            txtPurpose.Clear();
            dtpOutTime.Value = DateTime.Now;
            txtCompanion.Clear();
            txtCompanionPhone.Clear();
            txtOutingNotes.Clear();
        }

        private void ClearMealForm()
        {
            cmbMealResident.SelectedIndex = -1;
            dtpMealDate.Value = DateTime.Now;
            cmbMealType.SelectedIndex = -1;
            txtMenuItems.Clear();
            cmbAppetite.SelectedIndex = -1;
            txtSpecialDiet.Clear();
            txtMealNotes.Clear();
        }

        private void ClearCareForm()
        {
            cmbCareResident.SelectedIndex = -1;
            cmbCarePackage.SelectedIndex = -1;
            dtpCareDate.Value = DateTime.Now;
            cmbCareType.SelectedIndex = -1;
            txtCareContent.Clear();
            cmbCareResult.SelectedIndex = -1;
            txtCareNotes.Clear();
            txtCaregiverName.Clear();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
                _context?.Dispose();
            }
            base.Dispose(disposing);
        }

        // 添加缺失的事件处理方法
        private void btnClearOuting_Click(object sender, EventArgs e)
        {
            ClearOutingForm();
        }

        private void btnClearMeal_Click(object sender, EventArgs e)
        {
            ClearMealForm();
        }

        private void btnClearCare_Click(object sender, EventArgs e)
        {
            ClearCareForm();
        }
        private void ConfigureOutingGrid()
        {
            if (dgvOuting.Columns.Count > 0)
            {
                if (dgvOuting.Columns["Id"] != null)
                    dgvOuting.Columns["Id"].Visible = false;
                if (dgvOuting.Columns["ResidentId"] != null)
                    dgvOuting.Columns["ResidentId"].Visible = false;
                if (dgvOuting.Columns["Resident"] != null)
                {
                    dgvOuting.Columns["Resident"].HeaderText = "老人姓名";
                    // 为Resident列添加自定义显示格式
                    dgvOuting.Columns["Resident"].DefaultCellStyle.Format = "";
                }
                if (dgvOuting.Columns["Destination"] != null)
                    dgvOuting.Columns["Destination"].HeaderText = "目的地";
                if (dgvOuting.Columns["Purpose"] != null)
                    dgvOuting.Columns["Purpose"].HeaderText = "外出目的";
                if (dgvOuting.Columns["OutTime"] != null)
                    dgvOuting.Columns["OutTime"].HeaderText = "外出时间";
                if (dgvOuting.Columns["ReturnTime"] != null)
                    dgvOuting.Columns["ReturnTime"].HeaderText = "返回时间";
                if (dgvOuting.Columns["Companion"] != null)
                    dgvOuting.Columns["Companion"].HeaderText = "陪同人员";
                if (dgvOuting.Columns["Status"] != null)
                    dgvOuting.Columns["Status"].HeaderText = "状态";
                if (dgvOuting.Columns["Notes"] != null)
                    dgvOuting.Columns["Notes"].HeaderText = "备注";
            }

            // 添加单元格格式化事件处理
            dgvOuting.CellFormatting += DgvOuting_CellFormatting;
        }
        private void DgvOuting_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOuting.Columns[e.ColumnIndex].Name == "Resident" && e.Value is Resident resident)
            {
                e.Value = resident.Name;
                e.FormattingApplied = true;
            }
        }
        private void ConfigureMealsGrid()
        {
            if (dgvMeals.Columns.Count > 0)
            {
                if (dgvMeals.Columns["Id"] != null)
                    dgvMeals.Columns["Id"].Visible = false;
                if (dgvMeals.Columns["ResidentId"] != null)
                    dgvMeals.Columns["ResidentId"].Visible = false;
                if (dgvMeals.Columns["Resident"] != null)
                {
                    dgvMeals.Columns["Resident"].HeaderText = "老人姓名";
                }
                if (dgvMeals.Columns["MealDate"] != null)
                    dgvMeals.Columns["MealDate"].HeaderText = "用餐日期";
                if (dgvMeals.Columns["MealType"] != null)
                    dgvMeals.Columns["MealType"].HeaderText = "餐次";
                if (dgvMeals.Columns["MenuItems"] != null)
                    dgvMeals.Columns["MenuItems"].HeaderText = "食物内容";
                if (dgvMeals.Columns["Appetite"] != null)
                    dgvMeals.Columns["Appetite"].HeaderText = "食欲";
                if (dgvMeals.Columns["SpecialDiet"] != null)
                    dgvMeals.Columns["SpecialDiet"].HeaderText = "特殊饮食";
                if (dgvMeals.Columns["Notes"] != null)
                    dgvMeals.Columns["Notes"].HeaderText = "备注";
            }

            // 添加单元格格式化事件处理
            dgvMeals.CellFormatting += DgvMeals_CellFormatting;
        }

        private void DgvMeals_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMeals.Columns[e.ColumnIndex].Name == "Resident" && e.Value is Resident resident)
            {
                e.Value = resident.Name;
                e.FormattingApplied = true;
            }
        }
        private void ConfigureCareRecordsGrid()
        {
            if (dgvCareRecords.Columns.Count > 0)
            {
                if (dgvCareRecords.Columns["Id"] != null)
                    dgvCareRecords.Columns["Id"].Visible = false;
                if (dgvCareRecords.Columns["ResidentId"] != null)
                    dgvCareRecords.Columns["ResidentId"].Visible = false;
                if (dgvCareRecords.Columns["CarePackageId"] != null)
                    dgvCareRecords.Columns["CarePackageId"].Visible = false;
                if (dgvCareRecords.Columns["Resident"] != null)
                {
                    dgvCareRecords.Columns["Resident"].HeaderText = "老人姓名";
                }
                if (dgvCareRecords.Columns["CarePackage"] != null)
                {
                    dgvCareRecords.Columns["CarePackage"].HeaderText = "护理套餐";
                }
                if (dgvCareRecords.Columns["CareDate"] != null)
                    dgvCareRecords.Columns["CareDate"].HeaderText = "护理日期";
                if (dgvCareRecords.Columns["CareType"] != null)
                    dgvCareRecords.Columns["CareType"].HeaderText = "护理类型";
                if (dgvCareRecords.Columns["CareContent"] != null)
                    dgvCareRecords.Columns["CareContent"].HeaderText = "护理内容";
                if (dgvCareRecords.Columns["CareResult"] != null)
                    dgvCareRecords.Columns["CareResult"].HeaderText = "护理结果";
                if (dgvCareRecords.Columns["CaregiverName"] != null)
                    dgvCareRecords.Columns["CaregiverName"].HeaderText = "护理员";
                if (dgvCareRecords.Columns["Notes"] != null)
                    dgvCareRecords.Columns["Notes"].HeaderText = "备注";
            }

            // 添加单元格格式化事件处理
            dgvCareRecords.CellFormatting += DgvCareRecords_CellFormatting;
        }

        private void DgvCareRecords_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCareRecords.Columns[e.ColumnIndex].Name == "Resident" && e.Value is Resident resident)
            {
                e.Value = resident.Name;
                e.FormattingApplied = true;
            }
            else if (dgvCareRecords.Columns[e.ColumnIndex].Name == "CarePackage" && e.Value is CarePackage carePackage)
            {
                e.Value = carePackage.PackageName;
                e.FormattingApplied = true;
            }
        }
    }
}