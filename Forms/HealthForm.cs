using Microsoft.EntityFrameworkCore;
using WinFormsWorkApp1.Helpers;
using WinFormsWorkApp1.Models;

namespace WinFormsWorkApp1.Forms
{
    public partial class HealthForm : Form
    {
        private NursingHomeDbContext _context;
        private BindingSource _healthRecordBindingSource;
        private BindingSource _medicationRecordBindingSource;
        private BindingSource _medicalMonitoringBindingSource;
        private BindingSource _residentBindingSource;
        private BindingSource _medicationBindingSource;

        public HealthForm()
        {
            InitializeComponent();
            _context = new NursingHomeDbContext();
            _healthRecordBindingSource = new BindingSource();
            _medicationRecordBindingSource = new BindingSource();
            _medicalMonitoringBindingSource = new BindingSource();
            _residentBindingSource = new BindingSource();
            _medicationBindingSource = new BindingSource();

            InitializeData();
        }

        private async void InitializeData()
        {
            try
            {
                await _context.Database.EnsureCreatedAsync();
                await LoadDataAsync();
                SetupDataBindings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"初始化数据失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDataAsync()
        {
            // 加载老人信息
            var residents = await _context.Residents
                .Where(r => r.Status == "在住")
                .OrderBy(r => r.Name)
                .ToListAsync();
            _residentBindingSource.DataSource = residents;            // 加载健康记录
            var healthRecords = await _context.HealthRecords
                .Include(h => h.Resident)
                .Where(h => h.RecordDate >= DateTime.Today.AddDays(-30))
                .OrderByDescending(h => h.RecordDate)
                .Select(h => new
                {
                    Id = h.Id,
                    ResidentId = h.ResidentId,
                    老人姓名 = h.Resident.Name,
                    记录日期 = h.RecordDate,
                    记录类型 = h.RecordType,
                    收缩压 = h.BloodPressureHigh,
                    舒张压 = h.BloodPressureLow,
                    心率 = h.HeartRate,
                    体温 = h.Temperature,
                    血糖 = h.BloodSugar,
                    体重 = h.Weight,
                    身高 = h.Height,
                    症状 = h.Symptoms,
                    诊断 = h.Diagnosis,
                    治疗 = h.Treatment,
                    备注 = h.Notes,
                    记录人员类型 = h.RecorderType,
                    记录人员 = h.RecorderName
                })
                .ToListAsync();
            _healthRecordBindingSource.DataSource = healthRecords;            // 加载用药记录
            var medicationRecords = await _context.MedicationRecords
                .Include(mr => mr.Resident)
                .Include(mr => mr.Medication)
                .Where(mr => mr.Status == "进行中")
                .OrderByDescending(mr => mr.StartDate)
                .Select(mr => new
                {
                    Id = mr.Id,
                    ResidentId = mr.ResidentId,
                    MedicationId = mr.MedicationId,
                    老人姓名 = mr.Resident.Name,
                    药物名称 = mr.Medication.MedicationName,
                    开始日期 = mr.StartDate,
                    结束日期 = mr.EndDate,
                    剂量 = mr.Dosage,
                    频率 = mr.Frequency,
                    用法 = mr.Usage,
                    状态 = mr.Status,
                    用药目的 = mr.Purpose,
                    开药医生 = mr.PrescribedBy,
                    备注 = mr.Notes
                })
                .ToListAsync();
            _medicationRecordBindingSource.DataSource = medicationRecords;

            // 加载医疗监测记录
            var monitoringRecords = await _context.MedicalMonitorings
                .Include(mm => mm.Resident)
                .Where(mm => mm.MonitoringDate >= DateTime.Today.AddDays(-7))
                .OrderByDescending(mm => mm.MonitoringDate)
                .Select(mm => new
                {
                    Id = mm.Id,
                    ResidentId = mm.ResidentId,
                    老人姓名 = mm.Resident.Name,
                    监测日期 = mm.MonitoringDate,
                    监测类型 = mm.MonitoringType,
                    监测项目 = mm.MonitoringItem,
                    监测结果 = mm.Result,
                    单位 = mm.Unit,
                    正常范围 = mm.NormalRange,
                    状态 = mm.Status,
                    建议 = mm.Recommendations,
                    备注 = mm.Notes,
                    监测人员 = mm.MonitoredBy,
                    监测人员类型 = mm.MonitoredByType
                })
                .ToListAsync();
            _medicalMonitoringBindingSource.DataSource = monitoringRecords;

            // 加载药物信息
            var medications = await _context.Medications
                .Where(m => m.IsActive)
                .OrderBy(m => m.MedicationName)
                .ToListAsync();
            _medicationBindingSource.DataSource = medications;
        }

        private void SetupDataBindings()
        {
            try
            {                // 健康记录网格绑定 - 添加空值检查
                if (dgvHealthRecords != null && _healthRecordBindingSource != null)
                {
                    dgvHealthRecords.DataSource = _healthRecordBindingSource;
                    if (dgvHealthRecords.Columns.Count > 0)
                    {
                        if (dgvHealthRecords.Columns["Id"] != null)
                            dgvHealthRecords.Columns["Id"].Visible = false;
                        if (dgvHealthRecords.Columns["ResidentId"] != null)
                            dgvHealthRecords.Columns["ResidentId"].Visible = false;
                        if (dgvHealthRecords.Columns["老人姓名"] != null)
                            dgvHealthRecords.Columns["老人姓名"].HeaderText = "老人姓名";
                        if (dgvHealthRecords.Columns["记录日期"] != null)
                            dgvHealthRecords.Columns["记录日期"].HeaderText = "记录日期";
                        if (dgvHealthRecords.Columns["记录类型"] != null)
                            dgvHealthRecords.Columns["记录类型"].HeaderText = "记录类型";
                        if (dgvHealthRecords.Columns["收缩压"] != null)
                            dgvHealthRecords.Columns["收缩压"].HeaderText = "收缩压";
                        if (dgvHealthRecords.Columns["舒张压"] != null)
                            dgvHealthRecords.Columns["舒张压"].HeaderText = "舒张压";
                        if (dgvHealthRecords.Columns["心率"] != null)
                            dgvHealthRecords.Columns["心率"].HeaderText = "心率";
                        if (dgvHealthRecords.Columns["体温"] != null)
                            dgvHealthRecords.Columns["体温"].HeaderText = "体温";
                        if (dgvHealthRecords.Columns["血糖"] != null)
                            dgvHealthRecords.Columns["血糖"].HeaderText = "血糖";
                        if (dgvHealthRecords.Columns["体重"] != null)
                            dgvHealthRecords.Columns["体重"].HeaderText = "体重";
                        if (dgvHealthRecords.Columns["身高"] != null)
                            dgvHealthRecords.Columns["身高"].HeaderText = "身高";
                        if (dgvHealthRecords.Columns["症状"] != null)
                            dgvHealthRecords.Columns["症状"].HeaderText = "症状";
                        if (dgvHealthRecords.Columns["诊断"] != null)
                            dgvHealthRecords.Columns["诊断"].HeaderText = "诊断";
                        if (dgvHealthRecords.Columns["治疗"] != null)
                            dgvHealthRecords.Columns["治疗"].HeaderText = "治疗";
                        if (dgvHealthRecords.Columns["备注"] != null)
                            dgvHealthRecords.Columns["备注"].HeaderText = "备注";
                        if (dgvHealthRecords.Columns["记录人员类型"] != null)
                            dgvHealthRecords.Columns["记录人员类型"].HeaderText = "记录人员类型";
                        if (dgvHealthRecords.Columns["记录人员"] != null)
                            dgvHealthRecords.Columns["记录人员"].HeaderText = "记录人员";
                    }
                }                // 用药记录网格绑定 - 添加空值检查
                if (dgvMedicationRecords != null && _medicationRecordBindingSource != null)
                {
                    dgvMedicationRecords.DataSource = _medicationRecordBindingSource;
                    if (dgvMedicationRecords.Columns.Count > 0)
                    {
                        if (dgvMedicationRecords.Columns["Id"] != null)
                            dgvMedicationRecords.Columns["Id"].Visible = false;
                        if (dgvMedicationRecords.Columns["ResidentId"] != null)
                            dgvMedicationRecords.Columns["ResidentId"].Visible = false;
                        if (dgvMedicationRecords.Columns["MedicationId"] != null)
                            dgvMedicationRecords.Columns["MedicationId"].Visible = false;
                        if (dgvMedicationRecords.Columns["老人姓名"] != null)
                            dgvMedicationRecords.Columns["老人姓名"].HeaderText = "老人姓名";
                        if (dgvMedicationRecords.Columns["药物名称"] != null)
                            dgvMedicationRecords.Columns["药物名称"].HeaderText = "药物名称";
                        if (dgvMedicationRecords.Columns["开始日期"] != null)
                            dgvMedicationRecords.Columns["开始日期"].HeaderText = "开始日期";
                        if (dgvMedicationRecords.Columns["结束日期"] != null)
                            dgvMedicationRecords.Columns["结束日期"].HeaderText = "结束日期";
                        if (dgvMedicationRecords.Columns["剂量"] != null)
                            dgvMedicationRecords.Columns["剂量"].HeaderText = "剂量";
                        if (dgvMedicationRecords.Columns["频率"] != null)
                            dgvMedicationRecords.Columns["频率"].HeaderText = "频率";
                        if (dgvMedicationRecords.Columns["用法"] != null)
                            dgvMedicationRecords.Columns["用法"].HeaderText = "用法";
                        if (dgvMedicationRecords.Columns["状态"] != null)
                            dgvMedicationRecords.Columns["状态"].HeaderText = "状态";
                        if (dgvMedicationRecords.Columns["用药目的"] != null)
                            dgvMedicationRecords.Columns["用药目的"].HeaderText = "用药目的";
                        if (dgvMedicationRecords.Columns["开药医生"] != null)
                            dgvMedicationRecords.Columns["开药医生"].HeaderText = "开药医生";
                        if (dgvMedicationRecords.Columns["备注"] != null)
                            dgvMedicationRecords.Columns["备注"].HeaderText = "备注";
                    }
                }                // 医疗监测网格绑定 - 添加空值检查
                if (dgvMedicalMonitoring != null && _medicalMonitoringBindingSource != null)
                {
                    dgvMedicalMonitoring.DataSource = _medicalMonitoringBindingSource;
                    if (dgvMedicalMonitoring.Columns.Count > 0)
                    {
                        if (dgvMedicalMonitoring.Columns["Id"] != null)
                            dgvMedicalMonitoring.Columns["Id"].Visible = false;
                        if (dgvMedicalMonitoring.Columns["ResidentId"] != null)
                            dgvMedicalMonitoring.Columns["ResidentId"].Visible = false;
                        if (dgvMedicalMonitoring.Columns["老人姓名"] != null)
                            dgvMedicalMonitoring.Columns["老人姓名"].HeaderText = "老人姓名";
                        if (dgvMedicalMonitoring.Columns["监测日期"] != null)
                            dgvMedicalMonitoring.Columns["监测日期"].HeaderText = "监测日期";
                        if (dgvMedicalMonitoring.Columns["监测类型"] != null)
                            dgvMedicalMonitoring.Columns["监测类型"].HeaderText = "监测类型";
                        if (dgvMedicalMonitoring.Columns["监测项目"] != null)
                            dgvMedicalMonitoring.Columns["监测项目"].HeaderText = "监测项目";
                        if (dgvMedicalMonitoring.Columns["监测结果"] != null)
                            dgvMedicalMonitoring.Columns["监测结果"].HeaderText = "监测结果";
                        if (dgvMedicalMonitoring.Columns["单位"] != null)
                            dgvMedicalMonitoring.Columns["单位"].HeaderText = "单位";
                        if (dgvMedicalMonitoring.Columns["正常范围"] != null)
                            dgvMedicalMonitoring.Columns["正常范围"].HeaderText = "正常范围";
                        if (dgvMedicalMonitoring.Columns["状态"] != null)
                            dgvMedicalMonitoring.Columns["状态"].HeaderText = "状态";
                        if (dgvMedicalMonitoring.Columns["建议"] != null)
                            dgvMedicalMonitoring.Columns["建议"].HeaderText = "建议";
                        if (dgvMedicalMonitoring.Columns["备注"] != null)
                            dgvMedicalMonitoring.Columns["备注"].HeaderText = "备注";
                        if (dgvMedicalMonitoring.Columns["监测人员"] != null)
                            dgvMedicalMonitoring.Columns["监测人员"].HeaderText = "监测人员";
                        if (dgvMedicalMonitoring.Columns["监测人员类型"] != null)
                            dgvMedicalMonitoring.Columns["监测人员类型"].HeaderText = "监测人员类型";
                    }
                }

                // 下拉框绑定 - 添加空值检查
                if (cmbHealthResident != null && _residentBindingSource != null)
                {
                    cmbHealthResident.DataSource = _residentBindingSource;
                    cmbHealthResident.DisplayMember = "Name";
                    cmbHealthResident.ValueMember = "Id";
                }

                if (cmbMedicationResident != null && _residentBindingSource != null)
                {
                    cmbMedicationResident.DataSource = ((BindingSource)_residentBindingSource).DataSource;
                    cmbMedicationResident.DisplayMember = "Name";
                    cmbMedicationResident.ValueMember = "Id";
                }

                if (cmbMonitoringResident != null && _residentBindingSource != null)
                {
                    cmbMonitoringResident.DataSource = ((BindingSource)_residentBindingSource).DataSource;
                    cmbMonitoringResident.DisplayMember = "Name";
                    cmbMonitoringResident.ValueMember = "Id";
                }

                if (cmbMedication != null && _medicationBindingSource != null)
                {
                    cmbMedication.DataSource = _medicationBindingSource;
                    cmbMedication.DisplayMember = "MedicationName";
                    cmbMedication.ValueMember = "Id";
                }

                // 初始化下拉框选项 - 添加空值检查
                if (cmbRecordType != null)
                    cmbRecordType.Items.AddRange(new[] { "体检", "日常监测", "疾病记录" });
                if (cmbRecorderType != null)
                    cmbRecorderType.Items.AddRange(new[] { "护理人员", "医疗人员" });
                if (cmbMedicationStatus != null)
                    cmbMedicationStatus.Items.AddRange(new[] { "进行中", "已停药", "已完成" });
                if (cmbMonitoringType != null)
                    cmbMonitoringType.Items.AddRange(new[] { "血压监测", "血糖监测", "心电监测", "体温监测", "体重监测" });
                if (cmbMonitoringStatus != null)
                    cmbMonitoringStatus.Items.AddRange(new[] { "正常", "异常", "需关注" });
                if (cmbMonitoredByType != null)
                    cmbMonitoredByType.Items.AddRange(new[] { "护理人员", "医疗人员" });

                // 搜索下拉框
                if (cmbSearchRecordType != null)
                    cmbSearchRecordType.Items.AddRange(new[] { "体检", "日常监测", "疾病记录" });
                if (cmbSearchMedicationStatus != null)
                    cmbSearchMedicationStatus.Items.AddRange(new[] { "进行中", "已停药", "已完成" });
                if (cmbSearchMonitoringType != null)
                    cmbSearchMonitoringType.Items.AddRange(new[] { "血压监测", "血糖监测", "心电监测", "体温监测", "体重监测" });
                if (cmbSearchMonitoringStatus != null)
                    cmbSearchMonitoringStatus.Items.AddRange(new[] { "正常", "异常", "需关注" });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"设置数据绑定失败：{ex.Message}\n\n详细信息：{ex.StackTrace}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 添加健康记录
        private async void btnAddHealthRecord_Click(object sender, EventArgs e)
        {
            if (!ValidateHealthRecordInput())
                return;

            try
            {
                var healthRecord = new HealthRecord
                {
                    ResidentId = (int)cmbHealthResident.SelectedValue,
                    RecordDate = dtpHealthRecordDate.Value,
                    RecordType = cmbRecordType.Text,
                    BloodPressureHigh = numBloodPressureHigh.Value > 0 ? numBloodPressureHigh.Value : null,
                    BloodPressureLow = numBloodPressureLow.Value > 0 ? numBloodPressureLow.Value : null,
                    HeartRate = numHeartRate.Value > 0 ? numHeartRate.Value : null,
                    Temperature = numTemperature.Value > 0 ? numTemperature.Value : null,
                    BloodSugar = numBloodSugar.Value > 0 ? numBloodSugar.Value : null,
                    Weight = numWeight.Value > 0 ? numWeight.Value : null,
                    Height = numHeight.Value > 0 ? numHeight.Value : null,
                    Symptoms = txtSymptoms.Text.Trim(),
                    Diagnosis = txtDiagnosis.Text.Trim(),
                    Treatment = txtTreatment.Text.Trim(),
                    Notes = txtHealthNotes.Text.Trim(),
                    RecorderName = txtRecorderName.Text.Trim(),
                    RecorderType = cmbRecorderType.Text
                };

                _context.HealthRecords.Add(healthRecord);
                await _context.SaveChangesAsync();

                await LoadDataAsync();
                ClearHealthRecordForm();
                MessageBox.Show("健康记录添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加健康记录失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 添加用药记录
        private async void btnAddMedicationRecord_Click(object sender, EventArgs e)
        {
            if (!ValidateMedicationRecordInput())
                return;

            try
            {
                var medicationRecord = new MedicationRecord
                {
                    ResidentId = (int)cmbMedicationResident.SelectedValue,
                    MedicationId = (int)cmbMedication.SelectedValue,
                    StartDate = dtpMedicationStartDate.Value,
                    EndDate = chkHasEndDate.Checked ? dtpMedicationEndDate.Value : null,
                    Dosage = txtDosage.Text.Trim(),
                    Frequency = txtFrequency.Text.Trim(),
                    Usage = txtUsage.Text.Trim(),
                    Purpose = txtPurpose.Text.Trim(),
                    Notes = txtMedicationNotes.Text.Trim(),
                    PrescribedBy = txtPrescribedBy.Text.Trim(),
                    Status = cmbMedicationStatus.Text
                };

                _context.MedicationRecords.Add(medicationRecord);
                await _context.SaveChangesAsync();

                await LoadDataAsync();
                ClearMedicationRecordForm();
                MessageBox.Show("用药记录添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加用药记录失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 添加医疗监测记录
        private async void btnAddMonitoring_Click(object sender, EventArgs e)
        {
            if (!ValidateMonitoringInput())
                return;

            try
            {
                var monitoring = new MedicalMonitoring
                {
                    ResidentId = (int)cmbMonitoringResident.SelectedValue,
                    MonitoringDate = dtpMonitoringDate.Value,
                    MonitoringType = cmbMonitoringType.Text,
                    MonitoringItem = txtMonitoringItem.Text.Trim(),
                    Result = txtMonitoringResult.Text.Trim(),
                    Unit = txtUnit.Text.Trim(),
                    NormalRange = txtNormalRange.Text.Trim(),
                    Status = cmbMonitoringStatus.Text,
                    Recommendations = txtRecommendations.Text.Trim(),
                    Notes = txtMonitoringNotes.Text.Trim(),
                    MonitoredBy = txtMonitoredBy.Text.Trim(),
                    MonitoredByType = cmbMonitoredByType.Text
                };

                _context.MedicalMonitorings.Add(monitoring);
                await _context.SaveChangesAsync();

                await LoadDataAsync();
                ClearMonitoringForm();
                MessageBox.Show("医疗监测记录添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加医疗监测记录失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 验证方法
        private bool ValidateHealthRecordInput()
        {
            if (cmbHealthResident.SelectedValue == null)
            {
                MessageBox.Show("请选择老人！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbRecordType.Text))
            {
                MessageBox.Show("请选择记录类型！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRecorderName.Text))
            {
                MessageBox.Show("请输入记录人员！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateMedicationRecordInput()
        {
            if (cmbMedicationResident.SelectedValue == null)
            {
                MessageBox.Show("请选择老人！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbMedication.SelectedValue == null)
            {
                MessageBox.Show("请选择药物！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDosage.Text))
            {
                MessageBox.Show("请输入剂量！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFrequency.Text))
            {
                MessageBox.Show("请输入用药频率！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrescribedBy.Text))
            {
                MessageBox.Show("请输入开药医生！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbMedicationStatus.Text))
            {
                MessageBox.Show("请选择用药状态！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateMonitoringInput()
        {
            if (cmbMonitoringResident.SelectedValue == null)
            {
                MessageBox.Show("请选择老人！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbMonitoringType.Text))
            {
                MessageBox.Show("请选择监测类型！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMonitoringItem.Text))
            {
                MessageBox.Show("请输入监测项目！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMonitoringResult.Text))
            {
                MessageBox.Show("请输入监测结果！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMonitoredBy.Text))
            {
                MessageBox.Show("请输入监测人员！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }        // 清空表单方法
        private void ClearHealthRecordForm()
        {
            cmbHealthResident.SelectedIndex = -1;
            dtpHealthRecordDate.Value = DateTime.Now;
            cmbRecordType.SelectedIndex = -1;

            // 设置NumericUpDown控件的值，确保不低于最小值
            numBloodPressureHigh.Value = Math.Max(0, numBloodPressureHigh.Minimum);
            numBloodPressureLow.Value = Math.Max(0, numBloodPressureLow.Minimum);
            numHeartRate.Value = Math.Max(0, numHeartRate.Minimum);
            numTemperature.Value = Math.Max(36, numTemperature.Minimum); // 体温默认36度
            numBloodSugar.Value = Math.Max(0, numBloodSugar.Minimum);
            numWeight.Value = Math.Max(0, numWeight.Minimum);
            numHeight.Value = Math.Max(0, numHeight.Minimum);

            txtSymptoms.Clear();
            txtDiagnosis.Clear();
            txtTreatment.Clear();
            txtHealthNotes.Clear();
            txtRecorderName.Clear();
            cmbRecorderType.SelectedIndex = -1;
        }

        private void ClearMedicationRecordForm()
        {
            cmbMedicationResident.SelectedIndex = -1;
            cmbMedication.SelectedIndex = -1;
            dtpMedicationStartDate.Value = DateTime.Now;
            dtpMedicationEndDate.Value = DateTime.Now;
            chkHasEndDate.Checked = false;
            txtDosage.Clear();
            txtFrequency.Clear();
            txtUsage.Clear();
            txtPurpose.Clear();
            txtMedicationNotes.Clear();
            txtPrescribedBy.Clear();
            cmbMedicationStatus.SelectedIndex = -1;
        }

        private void ClearMonitoringForm()
        {
            cmbMonitoringResident.SelectedIndex = -1;
            dtpMonitoringDate.Value = DateTime.Now;
            cmbMonitoringType.SelectedIndex = -1;
            txtMonitoringItem.Clear();
            txtMonitoringResult.Clear();
            txtUnit.Clear();
            txtNormalRange.Clear();
            cmbMonitoringStatus.SelectedIndex = -1;
            txtRecommendations.Clear();
            txtMonitoringNotes.Clear();
            txtMonitoredBy.Clear();
            cmbMonitoredByType.SelectedIndex = -1;
        }

        // 清空按钮事件处理
        private void btnClearHealthRecord_Click(object sender, EventArgs e)
        {
            ClearHealthRecordForm();
        }

        private void btnClearMedicationRecord_Click(object sender, EventArgs e)
        {
            ClearMedicationRecordForm();
        }

        private void btnClearMonitoring_Click(object sender, EventArgs e)
        {
            ClearMonitoringForm();
        }

        // 结束日期复选框事件
        private void chkHasEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpMedicationEndDate.Enabled = chkHasEndDate.Checked;
        }        // 搜索功能
        private async void btnSearchHealth_Click(object sender, EventArgs e)
        {
            try
            {
                var query = _context.HealthRecords.Include(h => h.Resident).AsQueryable();

                // 按老人姓名搜索
                if (!string.IsNullOrWhiteSpace(txtSearchHealthResident.Text))
                {
                    string searchName = txtSearchHealthResident.Text.Trim();
                    query = query.Where(h => h.Resident.Name.Contains(searchName));
                }

                // 按记录类型搜索
                if (!string.IsNullOrWhiteSpace(cmbSearchRecordType.Text))
                {
                    query = query.Where(h => h.RecordType == cmbSearchRecordType.Text);
                }

                // 按日期范围搜索
                if (chkHealthDateRange.Checked)
                {
                    query = query.Where(h => h.RecordDate >= dtpHealthStartDate.Value.Date &&
                                           h.RecordDate <= dtpHealthEndDate.Value.Date);
                }

                var results = await query.OrderByDescending(h => h.RecordDate)
                    .Select(h => new
                    {
                        Id = h.Id,
                        ResidentId = h.ResidentId,
                        老人姓名 = h.Resident.Name,
                        记录日期 = h.RecordDate,
                        记录类型 = h.RecordType,
                        收缩压 = h.BloodPressureHigh,
                        舒张压 = h.BloodPressureLow,
                        心率 = h.HeartRate,
                        体温 = h.Temperature,
                        血糖 = h.BloodSugar,
                        体重 = h.Weight,
                        身高 = h.Height,
                        症状 = h.Symptoms,
                        诊断 = h.Diagnosis,
                        治疗 = h.Treatment,
                        备注 = h.Notes,
                        记录人员类型 = h.RecorderType,
                        记录人员 = h.RecorderName
                    })
                    .ToListAsync();
                _healthRecordBindingSource.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnSearchMedication_Click(object sender, EventArgs e)
        {
            try
            {
                var query = _context.MedicationRecords
                    .Include(mr => mr.Resident)
                    .Include(mr => mr.Medication)
                    .AsQueryable();

                // 按老人姓名搜索
                if (!string.IsNullOrWhiteSpace(txtSearchMedicationResident.Text))
                {
                    string searchName = txtSearchMedicationResident.Text.Trim();
                    query = query.Where(mr => mr.Resident.Name.Contains(searchName));
                }

                // 按药物名称搜索
                if (!string.IsNullOrWhiteSpace(txtSearchMedicationName.Text))
                {
                    string searchMedication = txtSearchMedicationName.Text.Trim();
                    query = query.Where(mr => mr.Medication.MedicationName.Contains(searchMedication));
                }

                // 按状态搜索
                if (!string.IsNullOrWhiteSpace(cmbSearchMedicationStatus.Text))
                {
                    query = query.Where(mr => mr.Status == cmbSearchMedicationStatus.Text);
                }

                var results = await query.OrderByDescending(mr => mr.StartDate)
                    .Select(mr => new
                    {
                        Id = mr.Id,
                        ResidentId = mr.ResidentId,
                        MedicationId = mr.MedicationId,
                        老人姓名 = mr.Resident.Name,
                        药物名称 = mr.Medication.MedicationName,
                        开始日期 = mr.StartDate,
                        结束日期 = mr.EndDate,
                        剂量 = mr.Dosage,
                        频率 = mr.Frequency,
                        用法 = mr.Usage,
                        状态 = mr.Status,
                        用药目的 = mr.Purpose,
                        开药医生 = mr.PrescribedBy,
                        备注 = mr.Notes
                    })
                    .ToListAsync();
                _medicationRecordBindingSource.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnSearchMonitoring_Click(object sender, EventArgs e)
        {
            try
            {
                var query = _context.MedicalMonitorings.Include(mm => mm.Resident).AsQueryable();

                // 按老人姓名搜索
                if (!string.IsNullOrWhiteSpace(txtSearchMonitoringResident.Text))
                {
                    string searchName = txtSearchMonitoringResident.Text.Trim();
                    query = query.Where(mm => mm.Resident.Name.Contains(searchName));
                }

                // 按监测类型搜索
                if (!string.IsNullOrWhiteSpace(cmbSearchMonitoringType.Text))
                {
                    query = query.Where(mm => mm.MonitoringType == cmbSearchMonitoringType.Text);
                }

                // 按状态搜索
                if (!string.IsNullOrWhiteSpace(cmbSearchMonitoringStatus.Text))
                {
                    query = query.Where(mm => mm.Status == cmbSearchMonitoringStatus.Text);
                }

                // 按日期范围搜索
                if (chkMonitoringDateRange.Checked)
                {
                    query = query.Where(mm => mm.MonitoringDate >= dtpMonitoringStartDate.Value.Date &&
                                            mm.MonitoringDate <= dtpMonitoringEndDate.Value.Date);
                }

                var results = await query.OrderByDescending(mm => mm.MonitoringDate)
                    .Select(mm => new
                    {
                        Id = mm.Id,
                        ResidentId = mm.ResidentId,
                        老人姓名 = mm.Resident.Name,
                        监测日期 = mm.MonitoringDate,
                        监测类型 = mm.MonitoringType,
                        监测项目 = mm.MonitoringItem,
                        监测结果 = mm.Result,
                        单位 = mm.Unit,
                        正常范围 = mm.NormalRange,
                        状态 = mm.Status,
                        建议 = mm.Recommendations,
                        备注 = mm.Notes,
                        监测人员 = mm.MonitoredBy,
                        监测人员类型 = mm.MonitoredByType
                    })
                    .ToListAsync();
                _medicalMonitoringBindingSource.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 重置搜索
        private async void btnResetHealthSearch_Click(object sender, EventArgs e)
        {
            txtSearchHealthResident.Clear();
            cmbSearchRecordType.SelectedIndex = -1;
            chkHealthDateRange.Checked = false;
            dtpHealthStartDate.Value = DateTime.Today.AddDays(-30);
            dtpHealthEndDate.Value = DateTime.Today;
            await LoadDataAsync();
        }

        private async void btnResetMedicationSearch_Click(object sender, EventArgs e)
        {
            txtSearchMedicationResident.Clear();
            txtSearchMedicationName.Clear();
            cmbSearchMedicationStatus.SelectedIndex = -1;
            await LoadDataAsync();
        }

        private async void btnResetMonitoringSearch_Click(object sender, EventArgs e)
        {
            txtSearchMonitoringResident.Clear();
            cmbSearchMonitoringType.SelectedIndex = -1;
            cmbSearchMonitoringStatus.SelectedIndex = -1;
            chkMonitoringDateRange.Checked = false;
            dtpMonitoringStartDate.Value = DateTime.Today.AddDays(-7);
            dtpMonitoringEndDate.Value = DateTime.Today;
            await LoadDataAsync();
        }

        // 日期范围复选框事件
        private void chkHealthDateRange_CheckedChanged(object sender, EventArgs e)
        {
            dtpHealthStartDate.Enabled = chkHealthDateRange.Checked;
            dtpHealthEndDate.Enabled = chkHealthDateRange.Checked;
        }

        private void chkMonitoringDateRange_CheckedChanged(object sender, EventArgs e)
        {
            dtpMonitoringStartDate.Enabled = chkMonitoringDateRange.Checked;
            dtpMonitoringEndDate.Enabled = chkMonitoringDateRange.Checked;
        }

        // 窗体关闭时释放资源
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
                _healthRecordBindingSource?.Dispose();
                _medicationRecordBindingSource?.Dispose();
                _medicalMonitoringBindingSource?.Dispose();
                _residentBindingSource?.Dispose();
                _medicationBindingSource?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}