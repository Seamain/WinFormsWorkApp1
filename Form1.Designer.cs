namespace WinFormsWorkApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMarketing = new System.Windows.Forms.Button();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.btnDailyLife = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(280, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "养老院管理系统";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(320, 80);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(160, 21);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "请选择要使用的功能";
            // 
            // btnMarketing
            // 
            this.btnMarketing.BackColor = System.Drawing.Color.LightBlue;
            this.btnMarketing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMarketing.Location = new System.Drawing.Point(150, 150);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Size = new System.Drawing.Size(150, 80);
            this.btnMarketing.TabIndex = 2;
            this.btnMarketing.Text = "营销管理";
            this.btnMarketing.UseVisualStyleBackColor = false;
            this.btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnAdmission
            // 
            this.btnAdmission.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdmission.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdmission.Location = new System.Drawing.Point(325, 150);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(150, 80);
            this.btnAdmission.TabIndex = 3;
            this.btnAdmission.Text = "入住管理";
            this.btnAdmission.UseVisualStyleBackColor = false;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
            // 
            // btnDailyLife
            // 
            this.btnDailyLife.BackColor = System.Drawing.Color.LightCoral;
            this.btnDailyLife.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDailyLife.Location = new System.Drawing.Point(500, 150);
            this.btnDailyLife.Name = "btnDailyLife";
            this.btnDailyLife.Size = new System.Drawing.Size(150, 80);
            this.btnDailyLife.TabIndex = 4;
            this.btnDailyLife.Text = "日常生活管理";
            this.btnDailyLife.UseVisualStyleBackColor = false;
            this.btnDailyLife.Click += new System.EventHandler(this.btnDailyLife_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.LightYellow;
            this.btnBilling.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBilling.Location = new System.Drawing.Point(150, 260);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(150, 80);
            this.btnBilling.TabIndex = 5;
            this.btnBilling.Text = "收费管理";
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnHealth
            // 
            this.btnHealth.BackColor = System.Drawing.Color.LightPink;
            this.btnHealth.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHealth.Location = new System.Drawing.Point(325, 260);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(150, 80);
            this.btnHealth.TabIndex = 6;
            this.btnHealth.Text = "健康管理";
            this.btnHealth.UseVisualStyleBackColor = false;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.LightGray;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployee.Location = new System.Drawing.Point(500, 260);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(150, 80);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "员工信息管理";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.LightSalmon;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInventory.Location = new System.Drawing.Point(325, 370);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(150, 80);
            this.btnInventory.TabIndex = 8;
            this.btnInventory.Text = "物品管理";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnHealth);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnDailyLife);
            this.Controls.Add(this.btnAdmission);
            this.Controls.Add(this.btnMarketing);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "养老院管理系统 - 主界面";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnMarketing;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnDailyLife;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnInventory;
    }
}
