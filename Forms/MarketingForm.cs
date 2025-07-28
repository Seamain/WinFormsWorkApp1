using Microsoft.EntityFrameworkCore;
using WinFormsWorkApp1.Helpers;
using WinFormsWorkApp1.Models;

namespace WinFormsWorkApp1.Forms
{
    public partial class MarketingForm : Form
    {
        private NursingHomeDbContext _context;
        private BindingSource _consultantBindingSource;
        private BindingSource _reservationBindingSource;
        private BindingSource _bedBindingSource;

        public MarketingForm()
        {
            InitializeComponent();
            _context = new NursingHomeDbContext();
            _consultantBindingSource = new BindingSource();
            _reservationBindingSource = new BindingSource();
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
                await LoadConsultantsAsync();
                await LoadReservationsAsync();
                await LoadBedsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"初始化数据失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadConsultantsAsync()
        {
            var consultants = await _context.Consultants
                .OrderByDescending(c => c.CreateTime)
                .ToListAsync(); _consultantBindingSource.DataSource = consultants;
            dgvConsultants.DataSource = _consultantBindingSource;

            // 配置咨询者DataGrid列标题
            ConfigureConsultantsGrid();

            // 更新咨询者下拉列表
            cmbConsultants.DataSource = consultants.ToList();
            cmbConsultants.DisplayMember = "Name";
            cmbConsultants.ValueMember = "Id";
        }

        private async Task LoadReservationsAsync()
        {
            var reservations = await _context.Reservations
                .Include(r => r.Consultant)
                .Include(r => r.Bed)
                .OrderByDescending(r => r.CreateTime)
                .ToListAsync(); _reservationBindingSource.DataSource = reservations;
            dgvReservations.DataSource = _reservationBindingSource;

            // 配置预订DataGrid列标题
            ConfigureReservationsGrid();
        }

        private async Task LoadBedsAsync()
        {
            var beds = await _context.Beds
                .Where(b => b.Status == "空闲")
                .OrderBy(b => b.RoomNumber)
                .ThenBy(b => b.BedNumber)
                .ToListAsync(); _bedBindingSource.DataSource = beds;
            dgvBeds.DataSource = _bedBindingSource;

            // 配置床位DataGrid列标题
            ConfigureBedsGrid();

            // 更新床位下拉列表
            cmbBeds.DataSource = beds.ToList();
            cmbBeds.DisplayMember = "BedNumber";
            cmbBeds.ValueMember = "Id";
        }

        private async void btnAddConsultant_Click(object sender, EventArgs e)
        {
            if (ValidateConsultantInput())
            {
                var consultant = new Consultant
                {
                    Name = txtConsultantName.Text.Trim(),
                    Phone = txtConsultantPhone.Text.Trim(),
                    Gender = cmbGender.Text,
                    Age = (int)nudAge.Value,
                    Address = txtAddress.Text.Trim(),
                    ContactPerson = txtContactPerson.Text.Trim(),
                    ContactPhone = txtContactPhone.Text.Trim(),
                    Notes = txtConsultantNotes.Text.Trim()
                };

                _context.Consultants.Add(consultant);
                await _context.SaveChangesAsync();

                await LoadConsultantsAsync();
                ClearConsultantForm();

                MessageBox.Show("咨询者信息添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (ValidateReservationInput())
            {
                var reservation = new Reservation
                {
                    ConsultantId = (int)cmbConsultants.SelectedValue,
                    BedId = cmbBeds.SelectedValue as int?,
                    ReservationDate = dtpReservationDate.Value,
                    PreferredMoveInDate = dtpMoveInDate.Value,
                    ServiceType = txtServiceType.Text.Trim(),
                    EstimatedCost = nudEstimatedCost.Value,
                    Requirements = txtRequirements.Text.Trim(),
                    Notes = txtReservationNotes.Text.Trim()
                };

                _context.Reservations.Add(reservation);

                // 如果选择了床位，更新床位状态
                if (reservation.BedId.HasValue)
                {
                    var bed = await _context.Beds.FindAsync(reservation.BedId.Value);
                    if (bed != null)
                    {
                        bed.Status = "已预定";
                        bed.UpdateTime = DateTime.Now;
                    }
                }

                await _context.SaveChangesAsync();

                await LoadReservationsAsync();
                await LoadBedsAsync();
                ClearReservationForm();

                MessageBox.Show("预定信息添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateConsultantInput()
        {
            if (string.IsNullOrWhiteSpace(txtConsultantName.Text))
            {
                MessageBox.Show("请输入咨询者姓名！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsultantName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtConsultantPhone.Text))
            {
                MessageBox.Show("请输入联系电话！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsultantPhone.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateReservationInput()
        {
            if (cmbConsultants.SelectedValue == null)
            {
                MessageBox.Show("请选择咨询者！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpMoveInDate.Value <= DateTime.Now.Date)
            {
                MessageBox.Show("预计入住日期必须是未来日期！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearConsultantForm()
        {
            txtConsultantName.Clear();
            txtConsultantPhone.Clear();
            cmbGender.SelectedIndex = -1;
            nudAge.Value = 60;
            txtAddress.Clear();
            txtContactPerson.Clear();
            txtContactPhone.Clear();
            txtConsultantNotes.Clear();
        }

        private void ClearReservationForm()
        {
            cmbConsultants.SelectedIndex = -1;
            cmbBeds.SelectedIndex = -1;
            dtpReservationDate.Value = DateTime.Now;
            dtpMoveInDate.Value = DateTime.Now.AddDays(7);
            txtServiceType.Clear();
            nudEstimatedCost.Value = 0;
            txtRequirements.Clear();
            txtReservationNotes.Clear();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnClearConsultant_Click(object sender, EventArgs e)
        {
            ClearConsultantForm();
        }

        private void btnClearReservation_Click(object sender, EventArgs e)
        {
            ClearReservationForm();
        }

        private void ConfigureConsultantsGrid()
        {
            if (dgvConsultants.Columns.Count > 0)
            {
                if (dgvConsultants.Columns["Id"] != null)
                    dgvConsultants.Columns["Id"].Visible = false;
                if (dgvConsultants.Columns["Name"] != null)
                    dgvConsultants.Columns["Name"].HeaderText = "姓名";
                if (dgvConsultants.Columns["Phone"] != null)
                    dgvConsultants.Columns["Phone"].HeaderText = "电话";
                if (dgvConsultants.Columns["Gender"] != null)
                    dgvConsultants.Columns["Gender"].HeaderText = "性别";
                if (dgvConsultants.Columns["Age"] != null)
                    dgvConsultants.Columns["Age"].HeaderText = "年龄";
                if (dgvConsultants.Columns["Address"] != null)
                    dgvConsultants.Columns["Address"].HeaderText = "地址";
                if (dgvConsultants.Columns["ContactPerson"] != null)
                    dgvConsultants.Columns["ContactPerson"].HeaderText = "联系人";
                if (dgvConsultants.Columns["ContactPhone"] != null)
                    dgvConsultants.Columns["ContactPhone"].HeaderText = "联系电话";
                if (dgvConsultants.Columns["Notes"] != null)
                    dgvConsultants.Columns["Notes"].HeaderText = "备注";
                if (dgvConsultants.Columns["CreateTime"] != null)
                    dgvConsultants.Columns["CreateTime"].HeaderText = "创建时间";
            }
        }

        private void ConfigureReservationsGrid()
        {
            if (dgvReservations.Columns.Count > 0)
            {
                if (dgvReservations.Columns["Id"] != null)
                    dgvReservations.Columns["Id"].Visible = false;
                if (dgvReservations.Columns["ConsultantId"] != null)
                    dgvReservations.Columns["ConsultantId"].Visible = false;
                if (dgvReservations.Columns["BedId"] != null)
                    dgvReservations.Columns["BedId"].Visible = false;
                if (dgvReservations.Columns["Consultant"] != null)
                    dgvReservations.Columns["Consultant"].HeaderText = "咨询者";
                if (dgvReservations.Columns["Bed"] != null)
                    dgvReservations.Columns["Bed"].HeaderText = "床位";
                if (dgvReservations.Columns["ReservationDate"] != null)
                    dgvReservations.Columns["ReservationDate"].HeaderText = "预订日期";
                if (dgvReservations.Columns["CheckInDate"] != null)
                    dgvReservations.Columns["CheckInDate"].HeaderText = "入住日期";
                if (dgvReservations.Columns["Status"] != null)
                    dgvReservations.Columns["Status"].HeaderText = "状态";
                if (dgvReservations.Columns["Notes"] != null)
                    dgvReservations.Columns["Notes"].HeaderText = "备注";
                if (dgvReservations.Columns["CreateTime"] != null)
                    dgvReservations.Columns["CreateTime"].HeaderText = "创建时间";
            }
        }

        private void ConfigureBedsGrid()
        {
            if (dgvBeds.Columns.Count > 0)
            {
                if (dgvBeds.Columns["Id"] != null)
                    dgvBeds.Columns["Id"].Visible = false;
                if (dgvBeds.Columns["RoomNumber"] != null)
                    dgvBeds.Columns["RoomNumber"].HeaderText = "房间号";
                if (dgvBeds.Columns["BedNumber"] != null)
                    dgvBeds.Columns["BedNumber"].HeaderText = "床位号";
                if (dgvBeds.Columns["BedType"] != null)
                    dgvBeds.Columns["BedType"].HeaderText = "床位类型";
                if (dgvBeds.Columns["MonthlyFee"] != null)
                    dgvBeds.Columns["MonthlyFee"].HeaderText = "月费";
                if (dgvBeds.Columns["Status"] != null)
                    dgvBeds.Columns["Status"].HeaderText = "状态";
                if (dgvBeds.Columns["Facilities"] != null)
                    dgvBeds.Columns["Facilities"].HeaderText = "设施";
                if (dgvBeds.Columns["Notes"] != null)
                    dgvBeds.Columns["Notes"].HeaderText = "备注";
            }
        }
    }
}