using Microsoft.EntityFrameworkCore;
using WinFormsWorkApp1.Helpers;
using WinFormsWorkApp1.Models;

namespace WinFormsWorkApp1.Forms
{
    public partial class AdmissionForm : Form
    {
        private NursingHomeDbContext _context;
        private BindingSource _residentBindingSource;
        private BindingSource _bedBindingSource;
        private Resident? _currentResident;

        public AdmissionForm()
        {
            InitializeComponent();
            _context = new NursingHomeDbContext();
            _residentBindingSource = new BindingSource();
            _bedBindingSource = new BindingSource();

            InitializeData();
        }

        private async void InitializeData()
        {
            try
            {
                // 确保数据库已创建
                await _context.Database.EnsureCreatedAsync();

                // 加载数据
                await LoadResidentsAsync();
                await LoadAvailableBedsAsync();                // 绑定数据
                dgvResidents.DataSource = _residentBindingSource;
                ConfigureResidentsGrid();

                cmbBeds.DataSource = _bedBindingSource;
                cmbBeds.DisplayMember = "BedNumber";
                cmbBeds.ValueMember = "Id";

                // 初始化状态下拉框
                cmbStatus.Items.AddRange(new[] { "待入住", "已入住", "已退住" });
                cmbGender.Items.AddRange(new[] { "男", "女" });

                // 设置默认值
                cmbStatus.SelectedIndex = 0;
                dtpCheckIn.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"初始化数据失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadResidentsAsync()
        {
            try
            {
                var residents = await _context.Residents
                    .Include(r => r.Bed)
                    .OrderByDescending(r => r.CreateTime)
                    .ToListAsync();

                _residentBindingSource.DataSource = residents;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载老人信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadAvailableBedsAsync()
        {
            try
            {
                var availableBeds = await _context.Beds
                    .Where(b => b.Status == "空闲")
                    .OrderBy(b => b.BedNumber)
                    .ToListAsync();

                _bedBindingSource.DataSource = availableBeds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载床位信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                var resident = new Resident
                {
                    Name = txtName.Text.Trim(),
                    IdCard = txtIdCard.Text.Trim(),
                    Gender = cmbGender.Text,
                    BirthDate = dtpBirthDate.Value,
                    Age = CalculateAge(dtpBirthDate.Value),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    EmergencyContact = txtEmergencyContact.Text.Trim(),
                    EmergencyPhone = txtEmergencyPhone.Text.Trim(),
                    MedicalHistory = txtMedicalHistory.Text.Trim(),
                    Allergies = txtAllergies.Text.Trim(),
                    Status = cmbStatus.Text,
                    Notes = txtNotes.Text.Trim(),
                    CreateTime = DateTime.Now
                };

                // 如果选择了床位且状态为已入住，分配床位
                if (cmbBeds.SelectedValue != null && cmbStatus.Text == "已入住")
                {
                    resident.BedId = (int)cmbBeds.SelectedValue;
                    resident.CheckInDate = dtpCheckIn.Value;

                    // 更新床位状态
                    var bed = await _context.Beds.FindAsync(resident.BedId);
                    if (bed != null)
                    {
                        bed.Status = "已入住";
                    }
                }

                _context.Residents.Add(resident);
                await _context.SaveChangesAsync();

                MessageBox.Show("老人信息添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                await LoadResidentsAsync();
                await LoadAvailableBedsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加老人信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentResident == null)
            {
                MessageBox.Show("请先选择要修改的老人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
                return;

            try
            {
                var resident = await _context.Residents.FindAsync(_currentResident.Id);
                if (resident == null)
                {
                    MessageBox.Show("老人信息不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 如果床位发生变化，需要更新床位状态
                if (resident.BedId != (int?)cmbBeds.SelectedValue)
                {
                    // 释放原床位
                    if (resident.BedId.HasValue)
                    {
                        var oldBed = await _context.Beds.FindAsync(resident.BedId.Value);
                        if (oldBed != null)
                        {
                            oldBed.Status = "空闲";
                        }
                    }

                    // 分配新床位
                    if (cmbBeds.SelectedValue != null && cmbStatus.Text == "已入住")
                    {
                        var newBed = await _context.Beds.FindAsync((int)cmbBeds.SelectedValue);
                        if (newBed != null)
                        {
                            newBed.Status = "已入住";
                        }
                    }
                }

                // 更新老人信息
                resident.Name = txtName.Text.Trim();
                resident.IdCard = txtIdCard.Text.Trim();
                resident.Gender = cmbGender.Text;
                resident.BirthDate = dtpBirthDate.Value;
                resident.Age = CalculateAge(dtpBirthDate.Value);
                resident.Phone = txtPhone.Text.Trim();
                resident.Address = txtAddress.Text.Trim();
                resident.EmergencyContact = txtEmergencyContact.Text.Trim();
                resident.EmergencyPhone = txtEmergencyPhone.Text.Trim();
                resident.MedicalHistory = txtMedicalHistory.Text.Trim();
                resident.Allergies = txtAllergies.Text.Trim();
                resident.Status = cmbStatus.Text;
                resident.Notes = txtNotes.Text.Trim();
                resident.UpdateTime = DateTime.Now;

                if (cmbBeds.SelectedValue != null && cmbStatus.Text == "已入住")
                {
                    resident.BedId = (int)cmbBeds.SelectedValue;
                    if (!resident.CheckInDate.HasValue)
                    {
                        resident.CheckInDate = dtpCheckIn.Value;
                    }
                }
                else if (cmbStatus.Text == "已退住")
                {
                    resident.CheckOutDate = DateTime.Now;
                    resident.BedId = null;
                }

                await _context.SaveChangesAsync();

                MessageBox.Show("老人信息修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                await LoadResidentsAsync();
                await LoadAvailableBedsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改老人信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentResident == null)
            {
                MessageBox.Show("请先选择要删除的老人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"确定要删除老人 {_currentResident.Name} 的信息吗？", "确认删除",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var resident = await _context.Residents.FindAsync(_currentResident.Id);
                    if (resident != null)
                    {
                        // 释放床位
                        if (resident.BedId.HasValue)
                        {
                            var bed = await _context.Beds.FindAsync(resident.BedId.Value);
                            if (bed != null)
                            {
                                bed.Status = "空闲";
                            }
                        }

                        _context.Residents.Remove(resident);
                        await _context.SaveChangesAsync();

                        MessageBox.Show("老人信息删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        await LoadResidentsAsync();
                        await LoadAvailableBedsAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"删除老人信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvResidents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResidents.CurrentRow?.DataBoundItem is Resident resident)
            {
                _currentResident = resident;
                LoadResidentToForm(resident);
            }
        }

        private void LoadResidentToForm(Resident resident)
        {
            txtName.Text = resident.Name;
            txtIdCard.Text = resident.IdCard;
            cmbGender.Text = resident.Gender;
            if (resident.BirthDate.HasValue)
                dtpBirthDate.Value = resident.BirthDate.Value;
            txtPhone.Text = resident.Phone;
            txtAddress.Text = resident.Address;
            txtEmergencyContact.Text = resident.EmergencyContact;
            txtEmergencyPhone.Text = resident.EmergencyPhone;
            txtMedicalHistory.Text = resident.MedicalHistory;
            txtAllergies.Text = resident.Allergies;
            cmbStatus.Text = resident.Status;
            txtNotes.Text = resident.Notes;

            if (resident.BedId.HasValue)
            {
                cmbBeds.SelectedValue = resident.BedId.Value;
            }

            if (resident.CheckInDate.HasValue)
            {
                dtpCheckIn.Value = resident.CheckInDate.Value;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("请输入老人姓名！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIdCard.Text))
            {
                MessageBox.Show("请输入身份证号！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdCard.Focus();
                return false;
            }

            if (cmbStatus.Text == "已入住" && cmbBeds.SelectedValue == null)
            {
                MessageBox.Show("已入住状态必须选择床位！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBeds.Focus();
                return false;
            }

            return true;
        }

        private int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age))
                age--;
            return age;
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtIdCard.Clear();
            cmbGender.SelectedIndex = -1;
            dtpBirthDate.Value = DateTime.Now.AddYears(-70);
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmergencyContact.Clear();
            txtEmergencyPhone.Clear();
            txtMedicalHistory.Clear();
            txtAllergies.Clear();
            cmbStatus.SelectedIndex = 0;
            cmbBeds.SelectedIndex = -1;
            txtNotes.Clear();
            dtpCheckIn.Value = DateTime.Now;
            _currentResident = null;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var query = _context.Residents.Include(r => r.Bed).AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtSearchName.Text))
                {
                    query = query.Where(r => r.Name.Contains(txtSearchName.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtSearchIdCard.Text))
                {
                    query = query.Where(r => r.IdCard.Contains(txtSearchIdCard.Text));
                }

                if (cmbSearchStatus.SelectedIndex > 0)
                {
                    query = query.Where(r => r.Status == cmbSearchStatus.Text);
                }

                var results = await query.OrderByDescending(r => r.CreateTime).ToListAsync();
                _residentBindingSource.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ConfigureResidentsGrid()
        {
            if (dgvResidents.Columns.Count > 0)
            {
                if (dgvResidents.Columns["Id"] != null)
                    dgvResidents.Columns["Id"].Visible = false;
                if (dgvResidents.Columns["BedId"] != null)
                    dgvResidents.Columns["BedId"].Visible = false;
                if (dgvResidents.Columns["Name"] != null)
                    dgvResidents.Columns["Name"].HeaderText = "姓名";
                if (dgvResidents.Columns["IdCard"] != null)
                    dgvResidents.Columns["IdCard"].HeaderText = "身份证号";
                if (dgvResidents.Columns["Gender"] != null)
                    dgvResidents.Columns["Gender"].HeaderText = "性别";
                if (dgvResidents.Columns["BirthDate"] != null)
                    dgvResidents.Columns["BirthDate"].HeaderText = "出生日期";
                if (dgvResidents.Columns["Age"] != null)
                    dgvResidents.Columns["Age"].HeaderText = "年龄";
                if (dgvResidents.Columns["Phone"] != null)
                    dgvResidents.Columns["Phone"].HeaderText = "联系电话";
                if (dgvResidents.Columns["Address"] != null)
                    dgvResidents.Columns["Address"].HeaderText = "家庭住址";
                if (dgvResidents.Columns["EmergencyContact"] != null)
                    dgvResidents.Columns["EmergencyContact"].HeaderText = "紧急联系人";
                if (dgvResidents.Columns["EmergencyPhone"] != null)
                    dgvResidents.Columns["EmergencyPhone"].HeaderText = "紧急联系电话";
                if (dgvResidents.Columns["CheckInDate"] != null)
                    dgvResidents.Columns["CheckInDate"].HeaderText = "入住日期";
                if (dgvResidents.Columns["Status"] != null)
                    dgvResidents.Columns["Status"].HeaderText = "状态";
                if (dgvResidents.Columns["Bed"] != null)
                    dgvResidents.Columns["Bed"].HeaderText = "床位";
                if (dgvResidents.Columns["MedicalHistory"] != null)
                    dgvResidents.Columns["MedicalHistory"].HeaderText = "病史";
                if (dgvResidents.Columns["Medications"] != null)
                    dgvResidents.Columns["Medications"].HeaderText = "服用药物";
                if (dgvResidents.Columns["Allergies"] != null)
                    dgvResidents.Columns["Allergies"].HeaderText = "过敏史";
                if (dgvResidents.Columns["SpecialNeeds"] != null)
                    dgvResidents.Columns["SpecialNeeds"].HeaderText = "特殊需求";
                if (dgvResidents.Columns["Notes"] != null)
                    dgvResidents.Columns["Notes"].HeaderText = "备注";
                if (dgvResidents.Columns["CreateTime"] != null)
                    dgvResidents.Columns["CreateTime"].HeaderText = "创建时间";

                // 设置日期格式
                if (dgvResidents.Columns["BirthDate"] != null)
                    dgvResidents.Columns["BirthDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                if (dgvResidents.Columns["CheckInDate"] != null)
                    dgvResidents.Columns["CheckInDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                if (dgvResidents.Columns["CreateTime"] != null)
                    dgvResidents.Columns["CreateTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            }
        }

        private void ConfigureSearchResultsGrid()
        {
            if (dgvSearchResults.Columns.Count > 0)
            {
                // 搜索结果网格配置与主网格相同
                ConfigureResidentsGrid();
            }
        }
    }
}