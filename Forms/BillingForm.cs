using Microsoft.EntityFrameworkCore;
using WinFormsWorkApp1.Helpers;
using WinFormsWorkApp1.Models;

namespace WinFormsWorkApp1.Forms
{
    public partial class BillingForm : Form
    {
        private NursingHomeDbContext _context;
        private BindingSource _feeRecordBindingSource;
        private BindingSource _paymentRecordBindingSource;
        private BindingSource _feeTypeBindingSource;
        private BindingSource _residentBindingSource;
        private FeeRecord? _currentFeeRecord;

        public BillingForm()
        {
            InitializeComponent();
            _context = new NursingHomeDbContext();
            _feeRecordBindingSource = new BindingSource();
            _paymentRecordBindingSource = new BindingSource();
            _feeTypeBindingSource = new BindingSource();
            _residentBindingSource = new BindingSource();

            InitializeData();
        }

        private async void InitializeData()
        {
            try
            {
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
            // 加载费用记录
            var feeRecords = await _context.FeeRecords
                .Include(f => f.Resident)
                .Include(f => f.FeeType)
                .Include(f => f.PaymentRecords)
                .OrderByDescending(f => f.CreateTime)
                .ToListAsync();
            _feeRecordBindingSource.DataSource = feeRecords;

            // 加载缴费记录
            var paymentRecords = await _context.PaymentRecords
                .Include(p => p.FeeRecord)
                .ThenInclude(f => f.Resident)
                .Include(p => p.FeeRecord)
                .ThenInclude(f => f.FeeType)
                .OrderByDescending(p => p.PaymentDate)
                .ToListAsync();
            _paymentRecordBindingSource.DataSource = paymentRecords;

            // 加载费用类型
            var feeTypes = await _context.FeeTypes
                .Where(ft => ft.IsActive)
                .ToListAsync();
            _feeTypeBindingSource.DataSource = feeTypes;

            // 加载老人信息
            var residents = await _context.Residents
                .Where(r => r.Status == "在住")
                .ToListAsync();
            _residentBindingSource.DataSource = residents;
        }

        private void SetupDataBindings()
        {
            // 费用记录网格绑定
            dgvFeeRecords.DataSource = _feeRecordBindingSource;
            dgvFeeRecords.Columns["Id"].Visible = false;
            dgvFeeRecords.Columns["ResidentId"].Visible = false;
            dgvFeeRecords.Columns["FeeTypeId"].Visible = false;
            dgvFeeRecords.Columns["Resident"].HeaderText = "老人姓名";
            dgvFeeRecords.Columns["FeeType"].HeaderText = "费用类型";
            dgvFeeRecords.Columns["Amount"].HeaderText = "费用金额";
            dgvFeeRecords.Columns["BillingDate"].HeaderText = "计费日期";
            dgvFeeRecords.Columns["DueDate"].HeaderText = "到期日期";
            dgvFeeRecords.Columns["Status"].HeaderText = "状态";
            dgvFeeRecords.Columns["Remarks"].HeaderText = "备注";
            dgvFeeRecords.Columns["CreateTime"].HeaderText = "创建时间";

            // 缴费记录网格绑定
            dgvPaymentRecords.DataSource = _paymentRecordBindingSource;
            dgvPaymentRecords.Columns["Id"].Visible = false;
            dgvPaymentRecords.Columns["FeeRecordId"].Visible = false;
            dgvPaymentRecords.Columns["PaymentAmount"].HeaderText = "缴费金额";
            dgvPaymentRecords.Columns["PaymentDate"].HeaderText = "缴费日期";
            dgvPaymentRecords.Columns["PaymentMethod"].HeaderText = "缴费方式";
            dgvPaymentRecords.Columns["ReceiptNumber"].HeaderText = "收据号";
            dgvPaymentRecords.Columns["Operator"].HeaderText = "操作员";
            dgvPaymentRecords.Columns["Remarks"].HeaderText = "备注";
            dgvPaymentRecords.Columns["CreateTime"].HeaderText = "创建时间";

            // 下拉框绑定
            cmbResident.DataSource = _residentBindingSource;
            cmbResident.DisplayMember = "Name";
            cmbResident.ValueMember = "Id";

            cmbFeeType.DataSource = _feeTypeBindingSource;
            cmbFeeType.DisplayMember = "TypeName";
            cmbFeeType.ValueMember = "Id";

            // 缴费方式下拉框
            cmbPaymentMethod.Items.AddRange(new[] { "现金", "银行卡", "支付宝", "微信支付", "银行转账" });
        }

        private async void btnAddFeeRecord_Click(object sender, EventArgs e)
        {
            if (!ValidateFeeRecordInput())
                return;

            try
            {
                var feeRecord = new FeeRecord
                {
                    ResidentId = (int)cmbResident.SelectedValue,
                    FeeTypeId = (int)cmbFeeType.SelectedValue,
                    Amount = numAmount.Value,
                    BillingDate = dtpBillingDate.Value,
                    DueDate = dtpDueDate.Value,
                    Status = "未缴费",
                    Remarks = txtFeeRemarks.Text.Trim()
                };

                _context.FeeRecords.Add(feeRecord);
                await _context.SaveChangesAsync();

                await LoadDataAsync();
                ClearFeeRecordForm();
                MessageBox.Show("费用记录添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加费用记录失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnPayment_Click(object sender, EventArgs e)
        {
            if (_currentFeeRecord == null)
            {
                MessageBox.Show("请先选择要缴费的费用记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidatePaymentInput())
                return;

            try
            {
                var paymentRecord = new PaymentRecord
                {
                    FeeRecordId = _currentFeeRecord.Id,
                    PaymentAmount = numPaymentAmount.Value,
                    PaymentDate = dtpPaymentDate.Value,
                    PaymentMethod = cmbPaymentMethod.Text,
                    ReceiptNumber = txtReceiptNumber.Text.Trim(),
                    Operator = txtOperator.Text.Trim(),
                    Remarks = txtPaymentRemarks.Text.Trim()
                };

                _context.PaymentRecords.Add(paymentRecord);

                // 更新费用记录状态
                var totalPaid = await _context.PaymentRecords
                    .Where(p => p.FeeRecordId == _currentFeeRecord.Id)
                    .SumAsync(p => p.PaymentAmount) + paymentRecord.PaymentAmount;

                if (totalPaid >= _currentFeeRecord.Amount)
                {
                    _currentFeeRecord.Status = "已缴费";
                }
                else
                {
                    _currentFeeRecord.Status = "部分缴费";
                }

                await _context.SaveChangesAsync();
                await LoadDataAsync();
                ClearPaymentForm();
                MessageBox.Show("缴费成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"缴费失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFeeRecords_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFeeRecords.CurrentRow?.DataBoundItem is FeeRecord feeRecord)
            {
                _currentFeeRecord = feeRecord;
                LoadFeeRecordDetails(feeRecord);
            }
        }

        private void LoadFeeRecordDetails(FeeRecord feeRecord)
        {
            lblSelectedFeeRecord.Text = $"选中费用：{feeRecord.Resident?.Name} - {feeRecord.FeeType?.TypeName} - ￥{feeRecord.Amount}";

            // 计算已缴费金额
            var totalPaid = feeRecord.PaymentRecords?.Sum(p => p.PaymentAmount) ?? 0;
            var remainingAmount = feeRecord.Amount - totalPaid;

            lblRemainingAmount.Text = $"剩余金额：￥{remainingAmount}";
            numPaymentAmount.Value = remainingAmount > 0 ? remainingAmount : 0;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var query = _context.FeeRecords
                    .Include(f => f.Resident)
                    .Include(f => f.FeeType)
                    .Include(f => f.PaymentRecords)
                    .AsQueryable();

                // 按老人姓名搜索
                if (!string.IsNullOrWhiteSpace(txtSearchResident.Text))
                {
                    query = query.Where(f => f.Resident.Name.Contains(txtSearchResident.Text));
                }

                // 按状态搜索
                if (cmbSearchStatus.SelectedItem != null && cmbSearchStatus.Text != "全部")
                {
                    query = query.Where(f => f.Status == cmbSearchStatus.Text);
                }

                // 按日期范围搜索
                if (chkDateRange.Checked)
                {
                    query = query.Where(f => f.BillingDate >= dtpStartDate.Value.Date &&
                                            f.BillingDate <= dtpEndDate.Value.Date);
                }

                var results = await query.OrderByDescending(f => f.CreateTime).ToListAsync();
                _feeRecordBindingSource.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFeeRecordInput()
        {
            if (cmbResident.SelectedValue == null)
            {
                MessageBox.Show("请选择老人！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbFeeType.SelectedValue == null)
            {
                MessageBox.Show("请选择费用类型！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("费用金额必须大于0！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidatePaymentInput()
        {
            if (numPaymentAmount.Value <= 0)
            {
                MessageBox.Show("缴费金额必须大于0！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbPaymentMethod.Text))
            {
                MessageBox.Show("请选择缴费方式！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOperator.Text))
            {
                MessageBox.Show("请输入操作员！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearFeeRecordForm()
        {
            cmbResident.SelectedIndex = -1;
            cmbFeeType.SelectedIndex = -1;
            numAmount.Value = 0;
            dtpBillingDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(30);
            txtFeeRemarks.Clear();
        }

        private void ClearPaymentForm()
        {
            numPaymentAmount.Value = 0;
            dtpPaymentDate.Value = DateTime.Now;
            cmbPaymentMethod.SelectedIndex = -1;
            txtReceiptNumber.Clear();
            txtOperator.Clear();
            txtPaymentRemarks.Clear();
        }

        private void btnClearFeeRecord_Click(object sender, EventArgs e)
        {
            ClearFeeRecordForm();
        }

        private void btnClearPayment_Click(object sender, EventArgs e)
        {
            ClearPaymentForm();
        }

        private void chkDateRange_CheckedChanged(object sender, EventArgs e)
        {
            // 启用或禁用日期范围选择控件
            dtpStartDate.Enabled = chkDateRange.Checked;
            dtpEndDate.Enabled = chkDateRange.Checked;
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
    }
}