using WinFormsWorkApp1.Forms;

namespace WinFormsWorkApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            try
            {
                var marketingForm = new MarketingForm();
                marketingForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开营销管理窗体失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            try
            {
                var admissionForm = new AdmissionForm();
                admissionForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开入住管理窗体失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDailyLife_Click(object sender, EventArgs e)
        {
            try
            {
                var dailyLifeForm = new DailyLifeForm();
                dailyLifeForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开日常生活管理窗体失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            try
            {
                var billingForm = new BillingForm();
                billingForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开收费管理窗体失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            try
            {
                var healthForm = new HealthForm();
                healthForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开健康管理窗体失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeForm = new EmployeeForm();
                employeeForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开员工信息管理窗体失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            try
            {
                var inventoryForm = new ItemManagementForm();
                inventoryForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开物品管理窗体失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
