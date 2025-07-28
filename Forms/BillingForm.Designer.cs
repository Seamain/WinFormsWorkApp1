namespace WinFormsWorkApp1.Forms
{
    partial class BillingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFeeManagement = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFeeRecord = new System.Windows.Forms.Button();
            this.btnAddFeeRecord = new System.Windows.Forms.Button();
            this.txtFeeRemarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBillingDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFeeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbResident = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFeeRecords = new System.Windows.Forms.DataGridView();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.lblSelectedFeeRecord = new System.Windows.Forms.Label();
            this.btnClearPayment = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtPaymentRemarks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReceiptNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.numPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPaymentRecords = new System.Windows.Forms.DataGridView();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.chkDateRange = new System.Windows.Forms.CheckBox();
            this.cmbSearchStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearchResident = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabFeeManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeRecords)).BeginInit();
            this.tabPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaymentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentRecords)).BeginInit();
            this.tabSearch.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFeeManagement);
            this.tabControl1.Controls.Add(this.tabPayment);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 700);
            this.tabControl1.TabIndex = 0;
            // 
            // tabFeeManagement
            // 
            this.tabFeeManagement.Controls.Add(this.splitContainer1);
            this.tabFeeManagement.Location = new System.Drawing.Point(4, 28);
            this.tabFeeManagement.Name = "tabFeeManagement";
            this.tabFeeManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeeManagement.Size = new System.Drawing.Size(1192, 668);
            this.tabFeeManagement.TabIndex = 0;
            this.tabFeeManagement.Text = "费用管理";
            this.tabFeeManagement.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvFeeRecords);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 662);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFeeRecord);
            this.groupBox1.Controls.Add(this.btnAddFeeRecord);
            this.groupBox1.Controls.Add(this.txtFeeRemarks);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDueDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpBillingDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbFeeType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbResident);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1186, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "费用记录管理";
            // 
            // btnClearFeeRecord
            // 
            this.btnClearFeeRecord.Location = new System.Drawing.Point(720, 200);
            this.btnClearFeeRecord.Name = "btnClearFeeRecord";
            this.btnClearFeeRecord.Size = new System.Drawing.Size(100, 35);
            this.btnClearFeeRecord.TabIndex = 13;
            this.btnClearFeeRecord.Text = "清空";
            this.btnClearFeeRecord.UseVisualStyleBackColor = true;
            this.btnClearFeeRecord.Click += new System.EventHandler(this.btnClearFeeRecord_Click);
            // 
            // btnAddFeeRecord
            // 
            this.btnAddFeeRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAddFeeRecord.ForeColor = System.Drawing.Color.White;
            this.btnAddFeeRecord.Location = new System.Drawing.Point(600, 200);
            this.btnAddFeeRecord.Name = "btnAddFeeRecord";
            this.btnAddFeeRecord.Size = new System.Drawing.Size(100, 35);
            this.btnAddFeeRecord.TabIndex = 12;
            this.btnAddFeeRecord.Text = "添加费用";
            this.btnAddFeeRecord.UseVisualStyleBackColor = false;
            this.btnAddFeeRecord.Click += new System.EventHandler(this.btnAddFeeRecord_Click);
            // 
            // txtFeeRemarks
            // 
            this.txtFeeRemarks.Location = new System.Drawing.Point(600, 120);
            this.txtFeeRemarks.Multiline = true;
            this.txtFeeRemarks.Name = "txtFeeRemarks";
            this.txtFeeRemarks.Size = new System.Drawing.Size(300, 60);
            this.txtFeeRemarks.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "备注:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(350, 120);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(180, 27);
            this.dtpDueDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "到期日期:";
            // 
            // dtpBillingDate
            // 
            this.dtpBillingDate.Location = new System.Drawing.Point(100, 120);
            this.dtpBillingDate.Name = "dtpBillingDate";
            this.dtpBillingDate.Size = new System.Drawing.Size(180, 27);
            this.dtpBillingDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "计费日期:";
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(600, 70);
            this.numAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(150, 27);
            this.numAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "金额:";
            // 
            // cmbFeeType
            // 
            this.cmbFeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeeType.Location = new System.Drawing.Point(350, 70);
            this.cmbFeeType.Name = "cmbFeeType";
            this.cmbFeeType.Size = new System.Drawing.Size(180, 28);
            this.cmbFeeType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "费用类型:";
            // 
            // cmbResident
            // 
            this.cmbResident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResident.Location = new System.Drawing.Point(100, 70);
            this.cmbResident.Name = "cmbResident";
            this.cmbResident.Size = new System.Drawing.Size(180, 28);
            this.cmbResident.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择老人:";
            // 
            // dgvFeeRecords
            // 
            this.dgvFeeRecords.AllowUserToAddRows = false;
            this.dgvFeeRecords.AllowUserToDeleteRows = false;
            this.dgvFeeRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeeRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeeRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFeeRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvFeeRecords.MultiSelect = false;
            this.dgvFeeRecords.Name = "dgvFeeRecords";
            this.dgvFeeRecords.ReadOnly = true;
            this.dgvFeeRecords.RowHeadersWidth = 51;
            this.dgvFeeRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeeRecords.Size = new System.Drawing.Size(1186, 378);
            this.dgvFeeRecords.TabIndex = 0;
            this.dgvFeeRecords.SelectionChanged += new System.EventHandler(this.dgvFeeRecords_SelectionChanged);
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.splitContainer2);
            this.tabPayment.Location = new System.Drawing.Point(4, 28);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(1192, 668);
            this.tabPayment.TabIndex = 1;
            this.tabPayment.Text = "费用缴纳";
            this.tabPayment.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvPaymentRecords);
            this.splitContainer2.Size = new System.Drawing.Size(1186, 662);
            this.splitContainer2.SplitterDistance = 320;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRemainingAmount);
            this.groupBox2.Controls.Add(this.lblSelectedFeeRecord);
            this.groupBox2.Controls.Add(this.btnClearPayment);
            this.groupBox2.Controls.Add(this.btnPayment);
            this.groupBox2.Controls.Add(this.txtPaymentRemarks);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtOperator);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtReceiptNumber);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbPaymentMethod);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpPaymentDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numPaymentAmount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1186, 320);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "费用缴纳";
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.AutoSize = true;
            this.lblRemainingAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemainingAmount.ForeColor = System.Drawing.Color.Red;
            this.lblRemainingAmount.Location = new System.Drawing.Point(30, 80);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(103, 24);
            this.lblRemainingAmount.TabIndex = 15;
            this.lblRemainingAmount.Text = "剩余金额：";
            // 
            // lblSelectedFeeRecord
            // 
            this.lblSelectedFeeRecord.AutoSize = true;
            this.lblSelectedFeeRecord.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedFeeRecord.ForeColor = System.Drawing.Color.Blue;
            this.lblSelectedFeeRecord.Location = new System.Drawing.Point(30, 40);
            this.lblSelectedFeeRecord.Name = "lblSelectedFeeRecord";
            this.lblSelectedFeeRecord.Size = new System.Drawing.Size(241, 24);
            this.lblSelectedFeeRecord.TabIndex = 14;
            this.lblSelectedFeeRecord.Text = "请在费用管理中选择费用记录";
            // 
            // btnClearPayment
            // 
            this.btnClearPayment.Location = new System.Drawing.Point(720, 250);
            this.btnClearPayment.Name = "btnClearPayment";
            this.btnClearPayment.Size = new System.Drawing.Size(100, 35);
            this.btnClearPayment.TabIndex = 13;
            this.btnClearPayment.Text = "清空";
            this.btnClearPayment.UseVisualStyleBackColor = true;
            this.btnClearPayment.Click += new System.EventHandler(this.btnClearPayment_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(600, 250);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(100, 35);
            this.btnPayment.TabIndex = 12;
            this.btnPayment.Text = "确认缴费";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtPaymentRemarks
            // 
            this.txtPaymentRemarks.Location = new System.Drawing.Point(600, 170);
            this.txtPaymentRemarks.Multiline = true;
            this.txtPaymentRemarks.Name = "txtPaymentRemarks";
            this.txtPaymentRemarks.Size = new System.Drawing.Size(300, 60);
            this.txtPaymentRemarks.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(550, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "备注:";
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(350, 170);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(180, 27);
            this.txtOperator.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "操作员:";
            // 
            // txtReceiptNumber
            // 
            this.txtReceiptNumber.Location = new System.Drawing.Point(100, 170);
            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptNumber.Size = new System.Drawing.Size(180, 27);
            this.txtReceiptNumber.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "收据号:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(600, 120);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(180, 28);
            this.cmbPaymentMethod.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "缴费方式:";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(350, 120);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(180, 27);
            this.dtpPaymentDate.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "缴费日期:";
            // 
            // numPaymentAmount
            // 
            this.numPaymentAmount.DecimalPlaces = 2;
            this.numPaymentAmount.Location = new System.Drawing.Point(100, 120);
            this.numPaymentAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPaymentAmount.Name = "numPaymentAmount";
            this.numPaymentAmount.Size = new System.Drawing.Size(150, 27);
            this.numPaymentAmount.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "缴费金额:";
            // 
            // dgvPaymentRecords
            // 
            this.dgvPaymentRecords.AllowUserToAddRows = false;
            this.dgvPaymentRecords.AllowUserToDeleteRows = false;
            this.dgvPaymentRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvPaymentRecords.MultiSelect = false;
            this.dgvPaymentRecords.Name = "dgvPaymentRecords";
            this.dgvPaymentRecords.ReadOnly = true;
            this.dgvPaymentRecords.RowHeadersWidth = 51;
            this.dgvPaymentRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentRecords.Size = new System.Drawing.Size(1186, 338);
            this.dgvPaymentRecords.TabIndex = 0;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.groupBox3);
            this.tabSearch.Location = new System.Drawing.Point(4, 28);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(1192, 668);
            this.tabSearch.TabIndex = 2;
            this.tabSearch.Text = "费用查询";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.dtpEndDate);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.dtpStartDate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.chkDateRange);
            this.groupBox3.Controls.Add(this.cmbSearchStatus);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtSearchResident);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1192, 150);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询条件";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(750, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(550, 80);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(180, 27);
            this.dtpEndDate.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(480, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "结束日期:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Location = new System.Drawing.Point(300, 80);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(180, 27);
            this.dtpStartDate.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(230, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "开始日期:";
            // 
            // chkDateRange
            // 
            this.chkDateRange.AutoSize = true;
            this.chkDateRange.Location = new System.Drawing.Point(30, 82);
            this.chkDateRange.Name = "chkDateRange";
            this.chkDateRange.Size = new System.Drawing.Size(106, 24);
            this.chkDateRange.TabIndex = 4;
            this.chkDateRange.Text = "按日期范围";
            this.chkDateRange.UseVisualStyleBackColor = true;
            this.chkDateRange.CheckedChanged += new System.EventHandler(this.chkDateRange_CheckedChanged);
            // 
            // cmbSearchStatus
            // 
            this.cmbSearchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchStatus.Items.AddRange(new object[] {
            "全部",
            "未缴费",
            "部分缴费",
            "已缴费",
            "逾期"});
            this.cmbSearchStatus.Location = new System.Drawing.Point(350, 40);
            this.cmbSearchStatus.Name = "cmbSearchStatus";
            this.cmbSearchStatus.Size = new System.Drawing.Size(150, 28);
            this.cmbSearchStatus.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(280, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "缴费状态:";
            // 
            // txtSearchResident
            // 
            this.txtSearchResident.Location = new System.Drawing.Point(100, 40);
            this.txtSearchResident.Name = "txtSearchResident";
            this.txtSearchResident.Size = new System.Drawing.Size(150, 27);
            this.txtSearchResident.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "老人姓名:";
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收费管理";
            this.tabControl1.ResumeLayout(false);
            this.tabFeeManagement.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeRecords)).EndInit();
            this.tabPayment.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaymentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentRecords)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFeeManagement;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearFeeRecord;
        private System.Windows.Forms.Button btnAddFeeRecord;
        private System.Windows.Forms.TextBox txtFeeRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBillingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFeeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbResident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFeeRecords;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRemainingAmount;
        private System.Windows.Forms.Label lblSelectedFeeRecord;
        private System.Windows.Forms.Button btnClearPayment;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox txtPaymentRemarks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReceiptNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPaymentAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPaymentRecords;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkDateRange;
        private System.Windows.Forms.ComboBox cmbSearchStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearchResident;
        private System.Windows.Forms.Label label13;
    }
}