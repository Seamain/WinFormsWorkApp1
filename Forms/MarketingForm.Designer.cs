namespace WinFormsWorkApp1.Forms
{
    partial class MarketingForm
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
            this.tabConsultants = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddConsultant = new System.Windows.Forms.Button();
            this.btnClearConsultant = new System.Windows.Forms.Button();
            this.txtConsultantNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConsultantPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsultantName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConsultants = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnClearReservation = new System.Windows.Forms.Button();
            this.txtReservationNotes = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRequirements = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.nudEstimatedCost = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpMoveInDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpReservationDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbBeds = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbConsultants = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tabBeds = new System.Windows.Forms.TabPage();
            this.dgvBeds = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabConsultants.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultants)).BeginInit();
            this.tabReservations.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.tabBeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConsultants);
            this.tabControl1.Controls.Add(this.tabReservations);
            this.tabControl1.Controls.Add(this.tabBeds);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 700);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConsultants
            // 
            this.tabConsultants.Controls.Add(this.groupBox1);
            this.tabConsultants.Controls.Add(this.dgvConsultants);
            this.tabConsultants.Controls.Add(this.label1);
            this.tabConsultants.Location = new System.Drawing.Point(4, 28);
            this.tabConsultants.Name = "tabConsultants";
            this.tabConsultants.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultants.Size = new System.Drawing.Size(1192, 668);
            this.tabConsultants.TabIndex = 0;
            this.tabConsultants.Text = "咨询者管理";
            this.tabConsultants.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddConsultant);
            this.groupBox1.Controls.Add(this.btnClearConsultant);
            this.groupBox1.Controls.Add(this.txtConsultantNotes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtContactPhone);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtContactPerson);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudAge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtConsultantPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtConsultantName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加咨询者信息";
            // 
            // btnAddConsultant
            // 
            this.btnAddConsultant.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddConsultant.Location = new System.Drawing.Point(950, 150);
            this.btnAddConsultant.Name = "btnAddConsultant";
            this.btnAddConsultant.Size = new System.Drawing.Size(90, 35);
            this.btnAddConsultant.TabIndex = 17;
            this.btnAddConsultant.Text = "添加";
            this.btnAddConsultant.UseVisualStyleBackColor = false;
            this.btnAddConsultant.Click += new System.EventHandler(this.btnAddConsultant_Click);
            // 
            // btnClearConsultant
            // 
            this.btnClearConsultant.BackColor = System.Drawing.Color.LightGray;
            this.btnClearConsultant.Location = new System.Drawing.Point(1050, 150);
            this.btnClearConsultant.Name = "btnClearConsultant";
            this.btnClearConsultant.Size = new System.Drawing.Size(90, 35);
            this.btnClearConsultant.TabIndex = 18;
            this.btnClearConsultant.Text = "清空";
            this.btnClearConsultant.UseVisualStyleBackColor = false;
            this.btnClearConsultant.Click += new System.EventHandler(this.btnClearConsultant_Click);
            // 
            // txtConsultantNotes
            // 
            this.txtConsultantNotes.Location = new System.Drawing.Point(650, 100);
            this.txtConsultantNotes.Multiline = true;
            this.txtConsultantNotes.Name = "txtConsultantNotes";
            this.txtConsultantNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsultantNotes.Size = new System.Drawing.Size(490, 40);
            this.txtConsultantNotes.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(580, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "备注：";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(450, 100);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(120, 25);
            this.txtContactPhone.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "联系人电话：";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(120, 100);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(120, 25);
            this.txtContactPerson.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "紧急联系人：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(650, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(490, 25);
            this.txtAddress.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "地址：";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(450, 60);
            this.nudAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(120, 25);
            this.nudAge.TabIndex = 8;
            this.nudAge.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "年龄：";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbGender.Location = new System.Drawing.Point(250, 60);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(120, 27);
            this.cmbGender.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "性别：";
            // 
            // txtConsultantPhone
            // 
            this.txtConsultantPhone.Location = new System.Drawing.Point(120, 60);
            this.txtConsultantPhone.Name = "txtConsultantPhone";
            this.txtConsultantPhone.Size = new System.Drawing.Size(120, 25);
            this.txtConsultantPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "联系电话：";
            // 
            // txtConsultantName
            // 
            this.txtConsultantName.Location = new System.Drawing.Point(120, 25);
            this.txtConsultantName.Name = "txtConsultantName";
            this.txtConsultantName.Size = new System.Drawing.Size(120, 25);
            this.txtConsultantName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // dgvConsultants
            // 
            this.dgvConsultants.AllowUserToAddRows = false;
            this.dgvConsultants.AllowUserToDeleteRows = false;
            this.dgvConsultants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultants.Location = new System.Drawing.Point(20, 270);
            this.dgvConsultants.Name = "dgvConsultants";
            this.dgvConsultants.ReadOnly = true;
            this.dgvConsultants.RowTemplate.Height = 25;
            this.dgvConsultants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultants.Size = new System.Drawing.Size(1150, 380);
            this.dgvConsultants.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "咨询者信息管理";
            // 
            // tabReservations
            // 
            this.tabReservations.Controls.Add(this.groupBox2);
            this.tabReservations.Controls.Add(this.dgvReservations);
            this.tabReservations.Controls.Add(this.label10);
            this.tabReservations.Location = new System.Drawing.Point(4, 28);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservations.Size = new System.Drawing.Size(1192, 668);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "预定服务管理";
            this.tabReservations.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddReservation);
            this.groupBox2.Controls.Add(this.btnClearReservation);
            this.groupBox2.Controls.Add(this.txtReservationNotes);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtRequirements);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.nudEstimatedCost);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtServiceType);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dtpMoveInDate);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtpReservationDate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbBeds);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbConsultants);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(20, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1150, 200);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加预定信息";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddReservation.Location = new System.Drawing.Point(950, 150);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(90, 35);
            this.btnAddReservation.TabIndex = 17;
            this.btnAddReservation.Text = "添加";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnClearReservation
            // 
            this.btnClearReservation.BackColor = System.Drawing.Color.LightGray;
            this.btnClearReservation.Location = new System.Drawing.Point(1050, 150);
            this.btnClearReservation.Name = "btnClearReservation";
            this.btnClearReservation.Size = new System.Drawing.Size(90, 35);
            this.btnClearReservation.TabIndex = 18;
            this.btnClearReservation.Text = "清空";
            this.btnClearReservation.UseVisualStyleBackColor = false;
            this.btnClearReservation.Click += new System.EventHandler(this.btnClearReservation_Click);
            // 
            // txtReservationNotes
            // 
            this.txtReservationNotes.Location = new System.Drawing.Point(650, 100);
            this.txtReservationNotes.Multiline = true;
            this.txtReservationNotes.Name = "txtReservationNotes";
            this.txtReservationNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReservationNotes.Size = new System.Drawing.Size(490, 40);
            this.txtReservationNotes.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(580, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "备注：";
            // 
            // txtRequirements
            // 
            this.txtRequirements.Location = new System.Drawing.Point(120, 100);
            this.txtRequirements.Multiline = true;
            this.txtRequirements.Name = "txtRequirements";
            this.txtRequirements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRequirements.Size = new System.Drawing.Size(450, 40);
            this.txtRequirements.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "特殊要求：";
            // 
            // nudEstimatedCost
            // 
            this.nudEstimatedCost.DecimalPlaces = 2;
            this.nudEstimatedCost.Location = new System.Drawing.Point(1020, 60);
            this.nudEstimatedCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudEstimatedCost.Name = "nudEstimatedCost";
            this.nudEstimatedCost.Size = new System.Drawing.Size(120, 25);
            this.nudEstimatedCost.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(920, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "预估费用：";
            // 
            // txtServiceType
            // 
            this.txtServiceType.Location = new System.Drawing.Point(780, 60);
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(120, 25);
            this.txtServiceType.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(680, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "服务类型：";
            // 
            // dtpMoveInDate
            // 
            this.dtpMoveInDate.Location = new System.Drawing.Point(520, 60);
            this.dtpMoveInDate.Name = "dtpMoveInDate";
            this.dtpMoveInDate.Size = new System.Drawing.Size(150, 25);
            this.dtpMoveInDate.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(420, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "预计入住日期：";
            // 
            // dtpReservationDate
            // 
            this.dtpReservationDate.Location = new System.Drawing.Point(250, 60);
            this.dtpReservationDate.Name = "dtpReservationDate";
            this.dtpReservationDate.Size = new System.Drawing.Size(150, 25);
            this.dtpReservationDate.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "预定日期：";
            // 
            // cmbBeds
            // 
            this.cmbBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeds.FormattingEnabled = true;
            this.cmbBeds.Location = new System.Drawing.Point(120, 60);
            this.cmbBeds.Name = "cmbBeds";
            this.cmbBeds.Size = new System.Drawing.Size(120, 27);
            this.cmbBeds.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "选择床位：";
            // 
            // cmbConsultants
            // 
            this.cmbConsultants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultants.FormattingEnabled = true;
            this.cmbConsultants.Location = new System.Drawing.Point(120, 25);
            this.cmbConsultants.Name = "cmbConsultants";
            this.cmbConsultants.Size = new System.Drawing.Size(200, 27);
            this.cmbConsultants.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "选择咨询者：";
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(20, 270);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowTemplate.Height = 25;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(1150, 380);
            this.dgvReservations.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(20, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 26);
            this.label10.TabIndex = 3;
            this.label10.Text = "预定服务管理";
            // 
            // tabBeds
            // 
            this.tabBeds.Controls.Add(this.dgvBeds);
            this.tabBeds.Controls.Add(this.label19);
            this.tabBeds.Location = new System.Drawing.Point(4, 28);
            this.tabBeds.Name = "tabBeds";
            this.tabBeds.Size = new System.Drawing.Size(1192, 668);
            this.tabBeds.TabIndex = 2;
            this.tabBeds.Text = "床位管理";
            this.tabBeds.UseVisualStyleBackColor = true;
            // 
            // dgvBeds
            // 
            this.dgvBeds.AllowUserToAddRows = false;
            this.dgvBeds.AllowUserToDeleteRows = false;
            this.dgvBeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeds.Location = new System.Drawing.Point(20, 60);
            this.dgvBeds.Name = "dgvBeds";
            this.dgvBeds.ReadOnly = true;
            this.dgvBeds.RowTemplate.Height = 25;
            this.dgvBeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeds.Size = new System.Drawing.Size(1150, 590);
            this.dgvBeds.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(20, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 26);
            this.label19.TabIndex = 0;
            this.label19.Text = "床位信息";
            // 
            // MarketingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MarketingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "营销管理 - 养老院管理系统";
            this.tabControl1.ResumeLayout(false);
            this.tabConsultants.ResumeLayout(false);
            this.tabConsultants.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultants)).EndInit();
            this.tabReservations.ResumeLayout(false);
            this.tabReservations.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimatedCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.tabBeds.ResumeLayout(false);
            this.tabBeds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsultants;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddConsultant;
        private System.Windows.Forms.Button btnClearConsultant;
        private System.Windows.Forms.TextBox txtConsultantNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsultantPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsultantName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConsultants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnClearReservation;
        private System.Windows.Forms.TextBox txtReservationNotes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRequirements;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudEstimatedCost;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpMoveInDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpReservationDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBeds;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbConsultants;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabBeds;
        private System.Windows.Forms.DataGridView dgvBeds;
        private System.Windows.Forms.Label label19;
    }
}