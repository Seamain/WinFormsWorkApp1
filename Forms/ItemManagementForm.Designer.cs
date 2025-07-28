namespace WinFormsWorkApp1.Forms
{
    partial class ItemManagementForm
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
            this.tabFacilities = new System.Windows.Forms.TabPage();
            this.tabWarehouses = new System.Windows.Forms.TabPage();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.tabStatistics = new System.Windows.Forms.TabPage();

            // 设施管理控件
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvFacilities = new System.Windows.Forms.DataGridView();
            this.txtFacilityName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFacilityCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFacilityLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFacilityDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFacilityPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.numFacilityPrice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFacilityManufacturer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFacilityModel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFacilityStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaintenanceRecord = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFacilityNotes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpLastMaintenance = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpNextMaintenance = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddFacility = new System.Windows.Forms.Button();
            this.btnUpdateFacility = new System.Windows.Forms.Button();
            this.btnDeleteFacility = new System.Windows.Forms.Button();
            this.btnClearFacility = new System.Windows.Forms.Button();
            this.txtSearchFacilityName = new System.Windows.Forms.TextBox();
            this.lblFacilityName = new System.Windows.Forms.Label();
            this.cmbSearchFacilityCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchFacilityStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchFacility = new System.Windows.Forms.Button();
            this.btnClearFacilitySearch = new System.Windows.Forms.Button();

            // 仓库管理控件
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvWarehouses = new System.Windows.Forms.DataGridView();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtWarehouseLocation = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtWarehouseDescription = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbWarehouseType = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.numWarehouseCapacity = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.txtWarehouseManager = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbWarehouseStatus = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtWarehouseNotes = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnAddWarehouse = new System.Windows.Forms.Button();
            this.btnUpdateWarehouse = new System.Windows.Forms.Button();
            this.btnDeleteWarehouse = new System.Windows.Forms.Button();
            this.btnClearWarehouse = new System.Windows.Forms.Button();
            this.txtSearchWarehouseName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbSearchWarehouseType = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSearchWarehouse = new System.Windows.Forms.Button();
            this.btnClearWarehouseSearch = new System.Windows.Forms.Button();

            // 物品管理控件
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtItemUnit = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.numItemPrice = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.txtItemSupplier = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cmbItemStatus = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.numMinStock = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.numMaxStock = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.txtItemNotes = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.txtSearchItemName = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.cmbSearchItemCategory = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.btnClearItemSearch = new System.Windows.Forms.Button();

            // 库存管理控件
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.cmbInventoryItem = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.cmbInventoryWarehouse = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.numCurrentStock = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.dtpLastInbound = new System.Windows.Forms.DateTimePicker();
            this.label42 = new System.Windows.Forms.Label();
            this.dtpLastOutbound = new System.Windows.Forms.DateTimePicker();
            this.label43 = new System.Windows.Forms.Label();
            this.txtInventoryNotes = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.btnDeleteInventory = new System.Windows.Forms.Button();
            this.btnClearInventory = new System.Windows.Forms.Button();
            this.cmbSearchInventoryItem = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.cmbSearchInventoryWarehouse = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.btnSearchInventory = new System.Windows.Forms.Button();
            this.btnClearInventorySearch = new System.Windows.Forms.Button();

            // 统计报表控件
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.cmbStatisticsType = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.dtpStatisticsStart = new System.Windows.Forms.DateTimePicker();
            this.label48 = new System.Windows.Forms.Label();
            this.dtpStatisticsEnd = new System.Windows.Forms.DateTimePicker();
            this.label49 = new System.Windows.Forms.Label();
            this.btnGenerateStatistics = new System.Windows.Forms.Button();
            this.btnExportStatistics = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            this.tabFacilities.SuspendLayout();
            this.tabWarehouses.SuspendLayout();
            this.tabItems.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFacilityPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWarehouseCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentStock)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFacilities);
            this.tabControl1.Controls.Add(this.tabWarehouses);
            this.tabControl1.Controls.Add(this.tabItems);
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Controls.Add(this.tabStatistics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 700);
            this.tabControl1.TabIndex = 0;

            // 
            // tabFacilities
            // 
            this.tabFacilities.Controls.Add(this.splitContainer1);
            this.tabFacilities.Location = new System.Drawing.Point(4, 25);
            this.tabFacilities.Name = "tabFacilities";
            this.tabFacilities.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacilities.Size = new System.Drawing.Size(1192, 671);
            this.tabFacilities.TabIndex = 0;
            this.tabFacilities.Text = "设施管理";
            this.tabFacilities.UseVisualStyleBackColor = true;

            // 
            // tabWarehouses
            // 
            this.tabWarehouses.Controls.Add(this.splitContainer2);
            this.tabWarehouses.Location = new System.Drawing.Point(4, 25);
            this.tabWarehouses.Name = "tabWarehouses";
            this.tabWarehouses.Padding = new System.Windows.Forms.Padding(3);
            this.tabWarehouses.Size = new System.Drawing.Size(1192, 671);
            this.tabWarehouses.TabIndex = 1;
            this.tabWarehouses.Text = "仓库管理";
            this.tabWarehouses.UseVisualStyleBackColor = true;

            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.splitContainer3);
            this.tabItems.Location = new System.Drawing.Point(4, 25);
            this.tabItems.Name = "tabItems";
            this.tabItems.Size = new System.Drawing.Size(1192, 671);
            this.tabItems.TabIndex = 2;
            this.tabItems.Text = "物品管理";
            this.tabItems.UseVisualStyleBackColor = true;

            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.splitContainer4);
            this.tabInventory.Location = new System.Drawing.Point(4, 25);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(1192, 671);
            this.tabInventory.TabIndex = 3;
            this.tabInventory.Text = "库存管理";
            this.tabInventory.UseVisualStyleBackColor = true;

            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.groupBox10);
            this.tabStatistics.Controls.Add(this.groupBox9);
            this.tabStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(1192, 671);
            this.tabStatistics.TabIndex = 4;
            this.tabStatistics.Text = "统计报表";
            this.tabStatistics.UseVisualStyleBackColor = true;

            // ========== 设施管理控件设置 ==========
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.dgvFacilities);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 665);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;

            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFacility);
            this.groupBox1.Controls.Add(this.btnDeleteFacility);
            this.groupBox1.Controls.Add(this.btnUpdateFacility);
            this.groupBox1.Controls.Add(this.btnAddFacility);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.dtpNextMaintenance);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtpLastMaintenance);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtFacilityNotes);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtMaintenanceRecord);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbFacilityStatus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtFacilityModel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtFacilityManufacturer);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numFacilityPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpFacilityPurchaseDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFacilityDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFacilityLocation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbFacilityCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFacilityName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1186, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设施信息";

            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearFacilitySearch);
            this.groupBox2.Controls.Add(this.btnSearchFacility);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbSearchFacilityStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbSearchFacilityCategory);
            this.groupBox2.Controls.Add(this.lblFacilityName);
            this.groupBox2.Controls.Add(this.txtSearchFacilityName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1186, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索条件";

            // 
            // dgvFacilities
            // 
            this.dgvFacilities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacilities.Location = new System.Drawing.Point(0, 86);
            this.dgvFacilities.Name = "dgvFacilities";
            this.dgvFacilities.RowHeadersWidth = 51;
            this.dgvFacilities.Size = new System.Drawing.Size(1186, 275);
            this.dgvFacilities.TabIndex = 0;

            // ========== 仓库管理控件设置 ==========
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
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel2.Controls.Add(this.dgvWarehouses);
            this.splitContainer2.Size = new System.Drawing.Size(1186, 665);
            this.splitContainer2.SplitterDistance = 250;
            this.splitContainer2.TabIndex = 0;

            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClearWarehouse);
            this.groupBox3.Controls.Add(this.btnDeleteWarehouse);
            this.groupBox3.Controls.Add(this.btnUpdateWarehouse);
            this.groupBox3.Controls.Add(this.btnAddWarehouse);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtWarehouseNotes);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cmbWarehouseStatus);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtWarehouseManager);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.numWarehouseCapacity);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.cmbWarehouseType);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtWarehouseDescription);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtWarehouseLocation);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtWarehouseName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1186, 250);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "仓库信息";

            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearWarehouseSearch);
            this.groupBox4.Controls.Add(this.btnSearchWarehouse);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.cmbSearchWarehouseType);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.txtSearchWarehouseName);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1186, 80);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "搜索条件";

            // 
            // dgvWarehouses
            // 
            this.dgvWarehouses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouses.Location = new System.Drawing.Point(0, 86);
            this.dgvWarehouses.Name = "dgvWarehouses";
            this.dgvWarehouses.RowHeadersWidth = 51;
            this.dgvWarehouses.Size = new System.Drawing.Size(1186, 325);
            this.dgvWarehouses.TabIndex = 0;

            // ========== 物品管理控件设置 ==========
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer3.Panel2.Controls.Add(this.dgvItems);
            this.splitContainer3.Size = new System.Drawing.Size(1186, 665);
            this.splitContainer3.SplitterDistance = 280;
            this.splitContainer3.TabIndex = 0;

            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnClearItem);
            this.groupBox5.Controls.Add(this.btnDeleteItem);
            this.groupBox5.Controls.Add(this.btnUpdateItem);
            this.groupBox5.Controls.Add(this.btnAddItem);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.txtItemNotes);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.numMaxStock);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.numMinStock);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.cmbItemStatus);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.txtItemSupplier);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.numItemPrice);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.txtItemUnit);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.txtItemDescription);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.txtItemCode);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.cmbItemCategory);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtItemName);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1186, 280);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "物品信息";

            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnClearItemSearch);
            this.groupBox6.Controls.Add(this.btnSearchItem);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.cmbSearchItemCategory);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.txtSearchItemName);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1186, 80);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "搜索条件";

            // 
            // dgvItems
            // 
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(0, 86);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(1186, 295);
            this.dgvItems.TabIndex = 0;

            // ========== 库存管理控件设置 ==========
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox7);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox8);
            this.splitContainer4.Panel2.Controls.Add(this.dgvInventory);
            this.splitContainer4.Size = new System.Drawing.Size(1186, 665);
            this.splitContainer4.SplitterDistance = 200;
            this.splitContainer4.TabIndex = 0;

            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnClearInventory);
            this.groupBox7.Controls.Add(this.btnDeleteInventory);
            this.groupBox7.Controls.Add(this.btnUpdateInventory);
            this.groupBox7.Controls.Add(this.btnAddInventory);
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Controls.Add(this.txtInventoryNotes);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.dtpLastOutbound);
            this.groupBox7.Controls.Add(this.label42);
            this.groupBox7.Controls.Add(this.dtpLastInbound);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.numCurrentStock);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this.cmbInventoryWarehouse);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.cmbInventoryItem);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1186, 200);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "库存信息";

            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnClearInventorySearch);
            this.groupBox8.Controls.Add(this.btnSearchInventory);
            this.groupBox8.Controls.Add(this.label46);
            this.groupBox8.Controls.Add(this.cmbSearchInventoryWarehouse);
            this.groupBox8.Controls.Add(this.label45);
            this.groupBox8.Controls.Add(this.cmbSearchInventoryItem);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1186, 80);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "搜索条件";

            // 
            // dgvInventory
            // 
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(0, 86);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.Size = new System.Drawing.Size(1186, 375);
            this.dgvInventory.TabIndex = 0;

            // ========== 统计报表控件设置 ==========
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnExportStatistics);
            this.groupBox9.Controls.Add(this.btnGenerateStatistics);
            this.groupBox9.Controls.Add(this.label49);
            this.groupBox9.Controls.Add(this.dtpStatisticsEnd);
            this.groupBox9.Controls.Add(this.label48);
            this.groupBox9.Controls.Add(this.dtpStatisticsStart);
            this.groupBox9.Controls.Add(this.label47);
            this.groupBox9.Controls.Add(this.cmbStatisticsType);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1186, 120);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "统计条件";

            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dgvStatistics);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(0, 120);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1186, 551);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "统计结果";

            // 
            // dgvStatistics
            // 
            this.dgvStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Location = new System.Drawing.Point(3, 21);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.RowHeadersWidth = 51;
            this.dgvStatistics.Size = new System.Drawing.Size(1180, 527);
            this.dgvStatistics.TabIndex = 0;

            // ========== 设施管理具体控件设置（使用原有的设置） ==========
            // 基本控件设置 - 第一行
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "设施名称:";

            // 
            // txtFacilityName
            // 
            this.txtFacilityName.Location = new System.Drawing.Point(90, 27);
            this.txtFacilityName.Name = "txtFacilityName";
            this.txtFacilityName.Size = new System.Drawing.Size(150, 25);
            this.txtFacilityName.TabIndex = 1;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "设施类别:";

            // 
            // cmbFacilityCategory
            // 
            this.cmbFacilityCategory.FormattingEnabled = true;
            this.cmbFacilityCategory.Location = new System.Drawing.Point(330, 27);
            this.cmbFacilityCategory.Name = "cmbFacilityCategory";
            this.cmbFacilityCategory.Size = new System.Drawing.Size(150, 23);
            this.cmbFacilityCategory.TabIndex = 3;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "设施位置:";

            // 
            // txtFacilityLocation
            // 
            this.txtFacilityLocation.Location = new System.Drawing.Point(570, 27);
            this.txtFacilityLocation.Name = "txtFacilityLocation";
            this.txtFacilityLocation.Size = new System.Drawing.Size(150, 25);
            this.txtFacilityLocation.TabIndex = 5;

            // 第二行控件
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "设施描述:";

            // 
            // txtFacilityDescription
            // 
            this.txtFacilityDescription.Location = new System.Drawing.Point(90, 62);
            this.txtFacilityDescription.Multiline = true;
            this.txtFacilityDescription.Name = "txtFacilityDescription";
            this.txtFacilityDescription.Size = new System.Drawing.Size(300, 60);
            this.txtFacilityDescription.TabIndex = 7;

            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "购买日期:";

            // 
            // dtpFacilityPurchaseDate
            // 
            this.dtpFacilityPurchaseDate.Location = new System.Drawing.Point(490, 62);
            this.dtpFacilityPurchaseDate.Name = "dtpFacilityPurchaseDate";
            this.dtpFacilityPurchaseDate.Size = new System.Drawing.Size(150, 25);
            this.dtpFacilityPurchaseDate.TabIndex = 9;

            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "价格:";

            // 
            // numFacilityPrice
            // 
            this.numFacilityPrice.DecimalPlaces = 2;
            this.numFacilityPrice.Location = new System.Drawing.Point(720, 62);
            this.numFacilityPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numFacilityPrice.Name = "numFacilityPrice";
            this.numFacilityPrice.Size = new System.Drawing.Size(120, 25);
            this.numFacilityPrice.TabIndex = 11;

            // 第三行控件
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "制造商:";

            // 
            // txtFacilityManufacturer
            // 
            this.txtFacilityManufacturer.Location = new System.Drawing.Point(90, 137);
            this.txtFacilityManufacturer.Name = "txtFacilityManufacturer";
            this.txtFacilityManufacturer.Size = new System.Drawing.Size(150, 25);
            this.txtFacilityManufacturer.TabIndex = 13;

            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "型号:";

            // 
            // txtFacilityModel
            // 
            this.txtFacilityModel.Location = new System.Drawing.Point(330, 137);
            this.txtFacilityModel.Name = "txtFacilityModel";
            this.txtFacilityModel.Size = new System.Drawing.Size(150, 25);
            this.txtFacilityModel.TabIndex = 15;

            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "状态:";

            // 
            // cmbFacilityStatus
            // 
            this.cmbFacilityStatus.FormattingEnabled = true;
            this.cmbFacilityStatus.Location = new System.Drawing.Point(570, 137);
            this.cmbFacilityStatus.Name = "cmbFacilityStatus";
            this.cmbFacilityStatus.Size = new System.Drawing.Size(150, 23);
            this.cmbFacilityStatus.TabIndex = 17;

            // 第四行控件
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "维护记录:";

            // 
            // txtMaintenanceRecord
            // 
            this.txtMaintenanceRecord.Location = new System.Drawing.Point(90, 177);
            this.txtMaintenanceRecord.Multiline = true;
            this.txtMaintenanceRecord.Name = "txtMaintenanceRecord";
            this.txtMaintenanceRecord.Size = new System.Drawing.Size(300, 60);
            this.txtMaintenanceRecord.TabIndex = 19;

            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(420, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "备注:";

            // 
            // txtFacilityNotes
            // 
            this.txtFacilityNotes.Location = new System.Drawing.Point(490, 177);
            this.txtFacilityNotes.Multiline = true;
            this.txtFacilityNotes.Name = "txtFacilityNotes";
            this.txtFacilityNotes.Size = new System.Drawing.Size(300, 60);
            this.txtFacilityNotes.TabIndex = 21;

            // 第五行控件
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(850, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "上次维护日期:";

            // 
            // dtpLastMaintenance
            // 
            this.dtpLastMaintenance.Location = new System.Drawing.Point(940, 62);
            this.dtpLastMaintenance.Name = "dtpLastMaintenance";
            this.dtpLastMaintenance.Size = new System.Drawing.Size(150, 25);
            this.dtpLastMaintenance.TabIndex = 23;

            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(850, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "下次维护日期:";

            // 
            // dtpNextMaintenance
            // 
            this.dtpNextMaintenance.Location = new System.Drawing.Point(940, 97);
            this.dtpNextMaintenance.Name = "dtpNextMaintenance";
            this.dtpNextMaintenance.Size = new System.Drawing.Size(150, 25);
            this.dtpNextMaintenance.TabIndex = 25;

            // 按钮控件
            // 
            // btnAddFacility
            // 
            this.btnAddFacility.Location = new System.Drawing.Point(850, 177);
            this.btnAddFacility.Name = "btnAddFacility";
            this.btnAddFacility.Size = new System.Drawing.Size(75, 30);
            this.btnAddFacility.TabIndex = 26;
            this.btnAddFacility.Text = "添加";
            this.btnAddFacility.UseVisualStyleBackColor = true;

            // 
            // btnUpdateFacility
            // 
            this.btnUpdateFacility.Location = new System.Drawing.Point(935, 177);
            this.btnUpdateFacility.Name = "btnUpdateFacility";
            this.btnUpdateFacility.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateFacility.TabIndex = 27;
            this.btnUpdateFacility.Text = "修改";
            this.btnUpdateFacility.UseVisualStyleBackColor = true;

            // 
            // btnDeleteFacility
            // 
            this.btnDeleteFacility.Location = new System.Drawing.Point(1020, 177);
            this.btnDeleteFacility.Name = "btnDeleteFacility";
            this.btnDeleteFacility.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteFacility.TabIndex = 28;
            this.btnDeleteFacility.Text = "删除";
            this.btnDeleteFacility.UseVisualStyleBackColor = true;

            // 
            // btnClearFacility
            // 
            this.btnClearFacility.Location = new System.Drawing.Point(850, 213);
            this.btnClearFacility.Name = "btnClearFacility";
            this.btnClearFacility.Size = new System.Drawing.Size(75, 30);
            this.btnClearFacility.TabIndex = 29;
            this.btnClearFacility.Text = "清空";
            this.btnClearFacility.UseVisualStyleBackColor = true;

            // 搜索区域控件
            // 
            // lblFacilityName
            // 
            this.lblFacilityName.AutoSize = true;
            this.lblFacilityName.Location = new System.Drawing.Point(20, 30);
            this.lblFacilityName.Name = "lblFacilityName";
            this.lblFacilityName.Size = new System.Drawing.Size(67, 15);
            this.lblFacilityName.TabIndex = 0;
            this.lblFacilityName.Text = "设施名称:";

            // 
            // txtSearchFacilityName
            // 
            this.txtSearchFacilityName.Location = new System.Drawing.Point(90, 27);
            this.txtSearchFacilityName.Name = "txtSearchFacilityName";
            this.txtSearchFacilityName.Size = new System.Drawing.Size(150, 25);
            this.txtSearchFacilityName.TabIndex = 1;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "类别:";

            // 
            // cmbSearchFacilityCategory
            // 
            this.cmbSearchFacilityCategory.FormattingEnabled = true;
            this.cmbSearchFacilityCategory.Location = new System.Drawing.Point(320, 27);
            this.cmbSearchFacilityCategory.Name = "cmbSearchFacilityCategory";
            this.cmbSearchFacilityCategory.Size = new System.Drawing.Size(150, 23);
            this.cmbSearchFacilityCategory.TabIndex = 3;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "状态:";

            // 
            // cmbSearchFacilityStatus
            // 
            this.cmbSearchFacilityStatus.FormattingEnabled = true;
            this.cmbSearchFacilityStatus.Location = new System.Drawing.Point(530, 27);
            this.cmbSearchFacilityStatus.Name = "cmbSearchFacilityStatus";
            this.cmbSearchFacilityStatus.Size = new System.Drawing.Size(150, 23);
            this.cmbSearchFacilityStatus.TabIndex = 5;

            // 
            // btnSearchFacility
            // 
            this.btnSearchFacility.Location = new System.Drawing.Point(700, 25);
            this.btnSearchFacility.Name = "btnSearchFacility";
            this.btnSearchFacility.Size = new System.Drawing.Size(75, 30);
            this.btnSearchFacility.TabIndex = 6;
            this.btnSearchFacility.Text = "搜索";
            this.btnSearchFacility.UseVisualStyleBackColor = true;

            // 
            // btnClearFacilitySearch
            // 
            this.btnClearFacilitySearch.Location = new System.Drawing.Point(785, 25);
            this.btnClearFacilitySearch.Name = "btnClearFacilitySearch";
            this.btnClearFacilitySearch.Size = new System.Drawing.Size(75, 30);
            this.btnClearFacilitySearch.TabIndex = 7;
            this.btnClearFacilitySearch.Text = "重置";
            this.btnClearFacilitySearch.UseVisualStyleBackColor = true;

            // ========== 仓库管理具体控件设置 ==========
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "仓库名称:";

            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(90, 27);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(150, 25);
            this.txtWarehouseName.TabIndex = 1;

            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(260, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "仓库位置:";

            // 
            // txtWarehouseLocation
            // 
            this.txtWarehouseLocation.Location = new System.Drawing.Point(330, 27);
            this.txtWarehouseLocation.Name = "txtWarehouseLocation";
            this.txtWarehouseLocation.Size = new System.Drawing.Size(150, 25);
            this.txtWarehouseLocation.TabIndex = 3;

            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(500, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 4;
            this.label18.Text = "仓库描述:";

            // 
            // txtWarehouseDescription
            // 
            this.txtWarehouseDescription.Location = new System.Drawing.Point(570, 27);
            this.txtWarehouseDescription.Multiline = true;
            this.txtWarehouseDescription.Name = "txtWarehouseDescription";
            this.txtWarehouseDescription.Size = new System.Drawing.Size(200, 60);
            this.txtWarehouseDescription.TabIndex = 5;

            // 第二行
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 6;
            this.label19.Text = "仓库类型:";

            // 
            // cmbWarehouseType
            // 
            this.cmbWarehouseType.FormattingEnabled = true;
            this.cmbWarehouseType.Location = new System.Drawing.Point(90, 97);
            this.cmbWarehouseType.Name = "cmbWarehouseType";
            this.cmbWarehouseType.Size = new System.Drawing.Size(150, 23);
            this.cmbWarehouseType.TabIndex = 7;

            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(260, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 15);
            this.label20.TabIndex = 8;
            this.label20.Text = "容量:";

            // 
            // numWarehouseCapacity
            // 
            this.numWarehouseCapacity.Location = new System.Drawing.Point(330, 97);
            this.numWarehouseCapacity.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numWarehouseCapacity.Name = "numWarehouseCapacity";
            this.numWarehouseCapacity.Size = new System.Drawing.Size(150, 25);
            this.numWarehouseCapacity.TabIndex = 9;

            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(500, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 15);
            this.label21.TabIndex = 10;
            this.label21.Text = "管理员:";

            // 
            // txtWarehouseManager
            // 
            this.txtWarehouseManager.Location = new System.Drawing.Point(570, 97);
            this.txtWarehouseManager.Name = "txtWarehouseManager";
            this.txtWarehouseManager.Size = new System.Drawing.Size(150, 25);
            this.txtWarehouseManager.TabIndex = 11;

            // 第三行
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 15);
            this.label22.TabIndex = 12;
            this.label22.Text = "状态:";

            // 
            // cmbWarehouseStatus
            // 
            this.cmbWarehouseStatus.FormattingEnabled = true;
            this.cmbWarehouseStatus.Location = new System.Drawing.Point(90, 137);
            this.cmbWarehouseStatus.Name = "cmbWarehouseStatus";
            this.cmbWarehouseStatus.Size = new System.Drawing.Size(150, 23);
            this.cmbWarehouseStatus.TabIndex = 13;

            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(260, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 15);
            this.label23.TabIndex = 14;
            this.label23.Text = "备注:";

            // 
            // txtWarehouseNotes
            // 
            this.txtWarehouseNotes.Location = new System.Drawing.Point(330, 137);
            this.txtWarehouseNotes.Multiline = true;
            this.txtWarehouseNotes.Name = "txtWarehouseNotes";
            this.txtWarehouseNotes.Size = new System.Drawing.Size(300, 60);
            this.txtWarehouseNotes.TabIndex = 15;

            // 仓库管理按钮
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.Location = new System.Drawing.Point(850, 137);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(75, 30);
            this.btnAddWarehouse.TabIndex = 16;
            this.btnAddWarehouse.Text = "添加";
            this.btnAddWarehouse.UseVisualStyleBackColor = true;

            // 
            // btnUpdateWarehouse
            // 
            this.btnUpdateWarehouse.Location = new System.Drawing.Point(935, 137);
            this.btnUpdateWarehouse.Name = "btnUpdateWarehouse";
            this.btnUpdateWarehouse.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateWarehouse.TabIndex = 17;
            this.btnUpdateWarehouse.Text = "修改";
            this.btnUpdateWarehouse.UseVisualStyleBackColor = true;

            // 
            // btnDeleteWarehouse
            // 
            this.btnDeleteWarehouse.Location = new System.Drawing.Point(1020, 137);
            this.btnDeleteWarehouse.Name = "btnDeleteWarehouse";
            this.btnDeleteWarehouse.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteWarehouse.TabIndex = 18;
            this.btnDeleteWarehouse.Text = "删除";
            this.btnDeleteWarehouse.UseVisualStyleBackColor = true;

            // 
            // btnClearWarehouse
            // 
            this.btnClearWarehouse.Location = new System.Drawing.Point(850, 173);
            this.btnClearWarehouse.Name = "btnClearWarehouse";
            this.btnClearWarehouse.Size = new System.Drawing.Size(75, 30);
            this.btnClearWarehouse.TabIndex = 19;
            this.btnClearWarehouse.Text = "清空";
            this.btnClearWarehouse.UseVisualStyleBackColor = true;

            // 仓库搜索控件
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 15);
            this.label24.TabIndex = 0;
            this.label24.Text = "仓库名称:";

            // 
            // txtSearchWarehouseName
            // 
            this.txtSearchWarehouseName.Location = new System.Drawing.Point(90, 27);
            this.txtSearchWarehouseName.Name = "txtSearchWarehouseName";
            this.txtSearchWarehouseName.Size = new System.Drawing.Size(150, 25);
            this.txtSearchWarehouseName.TabIndex = 1;

            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(260, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 15);
            this.label25.TabIndex = 2;
            this.label25.Text = "类型:";

            // 
            // cmbSearchWarehouseType
            // 
            this.cmbSearchWarehouseType.FormattingEnabled = true;
            this.cmbSearchWarehouseType.Location = new System.Drawing.Point(320, 27);
            this.cmbSearchWarehouseType.Name = "cmbSearchWarehouseType";
            this.cmbSearchWarehouseType.Size = new System.Drawing.Size(150, 23);
            this.cmbSearchWarehouseType.TabIndex = 3;

            // 
            // btnSearchWarehouse
            // 
            this.btnSearchWarehouse.Location = new System.Drawing.Point(500, 25);
            this.btnSearchWarehouse.Name = "btnSearchWarehouse";
            this.btnSearchWarehouse.Size = new System.Drawing.Size(75, 30);
            this.btnSearchWarehouse.TabIndex = 4;
            this.btnSearchWarehouse.Text = "搜索";
            this.btnSearchWarehouse.UseVisualStyleBackColor = true;

            // 
            // btnClearWarehouseSearch
            // 
            this.btnClearWarehouseSearch.Location = new System.Drawing.Point(585, 25);
            this.btnClearWarehouseSearch.Name = "btnClearWarehouseSearch";
            this.btnClearWarehouseSearch.Size = new System.Drawing.Size(75, 30);
            this.btnClearWarehouseSearch.TabIndex = 5;
            this.btnClearWarehouseSearch.Text = "重置";
            this.btnClearWarehouseSearch.UseVisualStyleBackColor = true;

            // ========== 物品管理具体控件设置 ==========
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 15);
            this.label26.TabIndex = 0;
            this.label26.Text = "物品名称:";

            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(90, 27);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(150, 25);
            this.txtItemName.TabIndex = 1;

            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(260, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 15);
            this.label27.TabIndex = 2;
            this.label27.Text = "物品类别:";

            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.FormattingEnabled = true;
            this.cmbItemCategory.Location = new System.Drawing.Point(330, 27);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(150, 23);
            this.cmbItemCategory.TabIndex = 3;

            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(500, 30);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 15);
            this.label28.TabIndex = 4;
            this.label28.Text = "物品编码:";

            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(570, 27);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(150, 25);
            this.txtItemCode.TabIndex = 5;

            // 第二行
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(20, 65);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 15);
            this.label29.TabIndex = 6;
            this.label29.Text = "物品描述:";

            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(90, 62);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(300, 60);
            this.txtItemDescription.TabIndex = 7;

            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(420, 65);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 15);
            this.label30.TabIndex = 8;
            this.label30.Text = "单位:";

            // 
            // txtItemUnit
            // 
            this.txtItemUnit.Location = new System.Drawing.Point(480, 62);
            this.txtItemUnit.Name = "txtItemUnit";
            this.txtItemUnit.Size = new System.Drawing.Size(100, 25);
            this.txtItemUnit.TabIndex = 9;

            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(600, 65);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 15);
            this.label31.TabIndex = 10;
            this.label31.Text = "价格:";

            // 
            // numItemPrice
            // 
            this.numItemPrice.DecimalPlaces = 2;
            this.numItemPrice.Location = new System.Drawing.Point(660, 62);
            this.numItemPrice.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numItemPrice.Name = "numItemPrice";
            this.numItemPrice.Size = new System.Drawing.Size(120, 25);
            this.numItemPrice.TabIndex = 11;

            // 第三行
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 140);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(67, 15);
            this.label32.TabIndex = 12;
            this.label32.Text = "供应商:";

            // 
            // txtItemSupplier
            // 
            this.txtItemSupplier.Location = new System.Drawing.Point(90, 137);
            this.txtItemSupplier.Name = "txtItemSupplier";
            this.txtItemSupplier.Size = new System.Drawing.Size(150, 25);
            this.txtItemSupplier.TabIndex = 13;

            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(260, 140);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(52, 15);
            this.label33.TabIndex = 14;
            this.label33.Text = "状态:";

            // 
            // cmbItemStatus
            // 
            this.cmbItemStatus.FormattingEnabled = true;
            this.cmbItemStatus.Location = new System.Drawing.Point(320, 137);
            this.cmbItemStatus.Name = "cmbItemStatus";
            this.cmbItemStatus.Size = new System.Drawing.Size(120, 23);
            this.cmbItemStatus.TabIndex = 15;

            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(460, 140);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(67, 15);
            this.label34.TabIndex = 16;
            this.label34.Text = "最低库存:";

            // 
            // numMinStock
            // 
            this.numMinStock.Location = new System.Drawing.Point(530, 137);
            this.numMinStock.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numMinStock.Name = "numMinStock";
            this.numMinStock.Size = new System.Drawing.Size(100, 25);
            this.numMinStock.TabIndex = 17;

            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(650, 140);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(67, 15);
            this.label35.TabIndex = 18;
            this.label35.Text = "最高库存:";

            // 
            // numMaxStock
            // 
            this.numMaxStock.Location = new System.Drawing.Point(720, 137);
            this.numMaxStock.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numMaxStock.Name = "numMaxStock";
            this.numMaxStock.Size = new System.Drawing.Size(100, 25);
            this.numMaxStock.TabIndex = 19;

            // 第四行
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(20, 180);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(37, 15);
            this.label36.TabIndex = 20;
            this.label36.Text = "备注:";

            // 
            // txtItemNotes
            // 
            this.txtItemNotes.Location = new System.Drawing.Point(90, 177);
            this.txtItemNotes.Multiline = true;
            this.txtItemNotes.Name = "txtItemNotes";
            this.txtItemNotes.Size = new System.Drawing.Size(400, 60);
            this.txtItemNotes.TabIndex = 21;

            // 物品管理按钮
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(850, 177);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 30);
            this.btnAddItem.TabIndex = 22;
            this.btnAddItem.Text = "添加";
            this.btnAddItem.UseVisualStyleBackColor = true;

            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(935, 177);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateItem.TabIndex = 23;
            this.btnUpdateItem.Text = "修改";
            this.btnUpdateItem.UseVisualStyleBackColor = true;

            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(1020, 177);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteItem.TabIndex = 24;
            this.btnDeleteItem.Text = "删除";
            this.btnDeleteItem.UseVisualStyleBackColor = true;

            // 
            // btnClearItem
            // 
            this.btnClearItem.Location = new System.Drawing.Point(850, 213);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(75, 30);
            this.btnClearItem.TabIndex = 25;
            this.btnClearItem.Text = "清空";
            this.btnClearItem.UseVisualStyleBackColor = true;

            // 物品搜索控件
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(20, 30);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(67, 15);
            this.label37.TabIndex = 0;
            this.label37.Text = "物品名称:";

            // 
            // txtSearchItemName
            // 
            this.txtSearchItemName.Location = new System.Drawing.Point(90, 27);
            this.txtSearchItemName.Name = "txtSearchItemName";
            this.txtSearchItemName.Size = new System.Drawing.Size(150, 25);
            this.txtSearchItemName.TabIndex = 1;

            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(260, 30);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(52, 15);
            this.label38.TabIndex = 2;
            this.label38.Text = "类别:";

            // 
            // cmbSearchItemCategory
            // 
            this.cmbSearchItemCategory.FormattingEnabled = true;
            this.cmbSearchItemCategory.Location = new System.Drawing.Point(320, 27);
            this.cmbSearchItemCategory.Name = "cmbSearchItemCategory";
            this.cmbSearchItemCategory.Size = new System.Drawing.Size(150, 23);
            this.cmbSearchItemCategory.TabIndex = 3;

            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Location = new System.Drawing.Point(500, 25);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(75, 30);
            this.btnSearchItem.TabIndex = 4;
            this.btnSearchItem.Text = "搜索";
            this.btnSearchItem.UseVisualStyleBackColor = true;

            // 
            // btnClearItemSearch
            // 
            this.btnClearItemSearch.Location = new System.Drawing.Point(585, 25);
            this.btnClearItemSearch.Name = "btnClearItemSearch";
            this.btnClearItemSearch.Size = new System.Drawing.Size(75, 30);
            this.btnClearItemSearch.TabIndex = 5;
            this.btnClearItemSearch.Text = "重置";
            this.btnClearItemSearch.UseVisualStyleBackColor = true;

            // ========== 库存管理具体控件设置 ==========
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(20, 30);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(52, 15);
            this.label39.TabIndex = 0;
            this.label39.Text = "物品:";

            // 
            // cmbInventoryItem
            // 
            this.cmbInventoryItem.FormattingEnabled = true;
            this.cmbInventoryItem.Location = new System.Drawing.Point(80, 27);
            this.cmbInventoryItem.Name = "cmbInventoryItem";
            this.cmbInventoryItem.Size = new System.Drawing.Size(200, 23);
            this.cmbInventoryItem.TabIndex = 1;

            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(300, 30);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(52, 15);
            this.label40.TabIndex = 2;
            this.label40.Text = "仓库:";

            // 
            // cmbInventoryWarehouse
            // 
            this.cmbInventoryWarehouse.FormattingEnabled = true;
            this.cmbInventoryWarehouse.Location = new System.Drawing.Point(360, 27);
            this.cmbInventoryWarehouse.Name = "cmbInventoryWarehouse";
            this.cmbInventoryWarehouse.Size = new System.Drawing.Size(200, 23);
            this.cmbInventoryWarehouse.TabIndex = 3;

            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(580, 30);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(67, 15);
            this.label41.TabIndex = 4;
            this.label41.Text = "当前库存:";

            // 
            // numCurrentStock
            // 
            this.numCurrentStock.Location = new System.Drawing.Point(650, 27);
            this.numCurrentStock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numCurrentStock.Name = "numCurrentStock";
            this.numCurrentStock.Size = new System.Drawing.Size(120, 25);
            this.numCurrentStock.TabIndex = 5;

            // 第二行
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(20, 70);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(82, 15);
            this.label42.TabIndex = 6;
            this.label42.Text = "最后入库日期:";

            // 
            // dtpLastInbound
            // 
            this.dtpLastInbound.Location = new System.Drawing.Point(110, 67);
            this.dtpLastInbound.Name = "dtpLastInbound";
            this.dtpLastInbound.Size = new System.Drawing.Size(170, 25);
            this.dtpLastInbound.TabIndex = 7;

            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(300, 70);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(82, 15);
            this.label43.TabIndex = 8;
            this.label43.Text = "最后出库日期:";

            // 
            // dtpLastOutbound
            // 
            this.dtpLastOutbound.Location = new System.Drawing.Point(390, 67);
            this.dtpLastOutbound.Name = "dtpLastOutbound";
            this.dtpLastOutbound.Size = new System.Drawing.Size(170, 25);
            this.dtpLastOutbound.TabIndex = 9;

            // 第三行
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(20, 110);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(37, 15);
            this.label44.TabIndex = 10;
            this.label44.Text = "备注:";

            // 
            // txtInventoryNotes
            // 
            this.txtInventoryNotes.Location = new System.Drawing.Point(80, 107);
            this.txtInventoryNotes.Multiline = true;
            this.txtInventoryNotes.Name = "txtInventoryNotes";
            this.txtInventoryNotes.Size = new System.Drawing.Size(400, 60);
            this.txtInventoryNotes.TabIndex = 11;

            // 库存管理按钮
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(850, 107);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(75, 30);
            this.btnAddInventory.TabIndex = 12;
            this.btnAddInventory.Text = "添加";
            this.btnAddInventory.UseVisualStyleBackColor = true;

            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.Location = new System.Drawing.Point(935, 107);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateInventory.TabIndex = 13;
            this.btnUpdateInventory.Text = "修改";
            this.btnUpdateInventory.UseVisualStyleBackColor = true;

            // 
            // btnDeleteInventory
            // 
            this.btnDeleteInventory.Location = new System.Drawing.Point(1020, 107);
            this.btnDeleteInventory.Name = "btnDeleteInventory";
            this.btnDeleteInventory.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteInventory.TabIndex = 14;
            this.btnDeleteInventory.Text = "删除";
            this.btnDeleteInventory.UseVisualStyleBackColor = true;

            // 
            // btnClearInventory
            // 
            this.btnClearInventory.Location = new System.Drawing.Point(850, 143);
            this.btnClearInventory.Name = "btnClearInventory";
            this.btnClearInventory.Size = new System.Drawing.Size(75, 30);
            this.btnClearInventory.TabIndex = 15;
            this.btnClearInventory.Text = "清空";
            this.btnClearInventory.UseVisualStyleBackColor = true;

            // 库存搜索控件
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(20, 30);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(52, 15);
            this.label45.TabIndex = 0;
            this.label45.Text = "物品:";

            // 
            // cmbSearchInventoryItem
            // 
            this.cmbSearchInventoryItem.FormattingEnabled = true;
            this.cmbSearchInventoryItem.Location = new System.Drawing.Point(80, 27);
            this.cmbSearchInventoryItem.Name = "cmbSearchInventoryItem";
            this.cmbSearchInventoryItem.Size = new System.Drawing.Size(200, 23);
            this.cmbSearchInventoryItem.TabIndex = 1;

            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(300, 30);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(52, 15);
            this.label46.TabIndex = 2;
            this.label46.Text = "仓库:";

            // 
            // cmbSearchInventoryWarehouse
            // 
            this.cmbSearchInventoryWarehouse.FormattingEnabled = true;
            this.cmbSearchInventoryWarehouse.Location = new System.Drawing.Point(360, 27);
            this.cmbSearchInventoryWarehouse.Name = "cmbSearchInventoryWarehouse";
            this.cmbSearchInventoryWarehouse.Size = new System.Drawing.Size(200, 23);
            this.cmbSearchInventoryWarehouse.TabIndex = 3;

            // 
            // btnSearchInventory
            // 
            this.btnSearchInventory.Location = new System.Drawing.Point(580, 25);
            this.btnSearchInventory.Name = "btnSearchInventory";
            this.btnSearchInventory.Size = new System.Drawing.Size(75, 30);
            this.btnSearchInventory.TabIndex = 4;
            this.btnSearchInventory.Text = "搜索";
            this.btnSearchInventory.UseVisualStyleBackColor = true;

            // 
            // btnClearInventorySearch
            // 
            this.btnClearInventorySearch.Location = new System.Drawing.Point(665, 25);
            this.btnClearInventorySearch.Name = "btnClearInventorySearch";
            this.btnClearInventorySearch.Size = new System.Drawing.Size(75, 30);
            this.btnClearInventorySearch.TabIndex = 5;
            this.btnClearInventorySearch.Text = "重置";
            this.btnClearInventorySearch.UseVisualStyleBackColor = true;

            // ========== 统计报表具体控件设置 ==========
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(20, 30);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(67, 15);
            this.label47.TabIndex = 0;
            this.label47.Text = "统计类型:";

            // 
            // cmbStatisticsType
            // 
            this.cmbStatisticsType.FormattingEnabled = true;
            this.cmbStatisticsType.Location = new System.Drawing.Point(90, 27);
            this.cmbStatisticsType.Name = "cmbStatisticsType";
            this.cmbStatisticsType.Size = new System.Drawing.Size(200, 23);
            this.cmbStatisticsType.TabIndex = 1;

            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(320, 30);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(67, 15);
            this.label48.TabIndex = 2;
            this.label48.Text = "开始日期:";

            // 
            // dtpStatisticsStart
            // 
            this.dtpStatisticsStart.Location = new System.Drawing.Point(390, 27);
            this.dtpStatisticsStart.Name = "dtpStatisticsStart";
            this.dtpStatisticsStart.Size = new System.Drawing.Size(150, 25);
            this.dtpStatisticsStart.TabIndex = 3;

            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(570, 30);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(67, 15);
            this.label49.TabIndex = 4;
            this.label49.Text = "结束日期:";

            // 
            // dtpStatisticsEnd
            // 
            this.dtpStatisticsEnd.Location = new System.Drawing.Point(640, 27);
            this.dtpStatisticsEnd.Name = "dtpStatisticsEnd";
            this.dtpStatisticsEnd.Size = new System.Drawing.Size(150, 25);
            this.dtpStatisticsEnd.TabIndex = 5;

            // 统计按钮
            // 
            // btnGenerateStatistics
            // 
            this.btnGenerateStatistics.Location = new System.Drawing.Point(820, 25);
            this.btnGenerateStatistics.Name = "btnGenerateStatistics";
            this.btnGenerateStatistics.Size = new System.Drawing.Size(100, 30);
            this.btnGenerateStatistics.TabIndex = 6;
            this.btnGenerateStatistics.Text = "生成统计";
            this.btnGenerateStatistics.UseVisualStyleBackColor = true;

            // 
            // btnExportStatistics
            // 
            this.btnExportStatistics.Location = new System.Drawing.Point(930, 25);
            this.btnExportStatistics.Name = "btnExportStatistics";
            this.btnExportStatistics.Size = new System.Drawing.Size(100, 30);
            this.btnExportStatistics.TabIndex = 7;
            this.btnExportStatistics.Text = "导出报表";
            this.btnExportStatistics.UseVisualStyleBackColor = true;

            // 
            // ItemManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.Name = "ItemManagementForm";
            this.Text = "物品管理";
            this.tabControl1.ResumeLayout(false);
            this.tabFacilities.ResumeLayout(false);
            this.tabWarehouses.ResumeLayout(false);
            this.tabItems.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            this.tabStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFacilityPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWarehouseCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentStock)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFacilities;
        private System.Windows.Forms.TabPage tabWarehouses;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabStatistics;

        // 设施管理控件
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFacilities;
        private System.Windows.Forms.TextBox txtFacilityName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFacilityCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFacilityLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFacilityDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFacilityPurchaseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numFacilityPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFacilityManufacturer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFacilityModel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFacilityStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaintenanceRecord;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFacilityNotes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpLastMaintenance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpNextMaintenance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddFacility;
        private System.Windows.Forms.Button btnUpdateFacility;
        private System.Windows.Forms.Button btnDeleteFacility;
        private System.Windows.Forms.Button btnClearFacility;
        private System.Windows.Forms.TextBox txtSearchFacilityName;
        private System.Windows.Forms.Label lblFacilityName;
        private System.Windows.Forms.ComboBox cmbSearchFacilityCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchFacilityStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchFacility;
        private System.Windows.Forms.Button btnClearFacilitySearch;

        // 仓库管理控件
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvWarehouses;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtWarehouseLocation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtWarehouseDescription;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbWarehouseType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numWarehouseCapacity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtWarehouseManager;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbWarehouseStatus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtWarehouseNotes;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnAddWarehouse;
        private System.Windows.Forms.Button btnUpdateWarehouse;
        private System.Windows.Forms.Button btnDeleteWarehouse;
        private System.Windows.Forms.Button btnClearWarehouse;
        private System.Windows.Forms.TextBox txtSearchWarehouseName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbSearchWarehouseType;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnSearchWarehouse;
        private System.Windows.Forms.Button btnClearWarehouseSearch;

        // 物品管理控件
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbItemCategory;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtItemUnit;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown numItemPrice;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtItemSupplier;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cmbItemStatus;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown numMinStock;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown numMaxStock;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtItemNotes;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.TextBox txtSearchItemName;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cmbSearchItemCategory;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.Button btnClearItemSearch;

        // 库存管理控件
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.ComboBox cmbInventoryItem;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox cmbInventoryWarehouse;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown numCurrentStock;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DateTimePicker dtpLastInbound;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DateTimePicker dtpLastOutbound;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtInventoryNotes;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button btnAddInventory;
        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.Button btnDeleteInventory;
        private System.Windows.Forms.Button btnClearInventory;
        private System.Windows.Forms.ComboBox cmbSearchInventoryItem;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox cmbSearchInventoryWarehouse;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button btnSearchInventory;
        private System.Windows.Forms.Button btnClearInventorySearch;

        // 统计报表控件
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.ComboBox cmbStatisticsType;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.DateTimePicker dtpStatisticsStart;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.DateTimePicker dtpStatisticsEnd;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button btnGenerateStatistics;
        private System.Windows.Forms.Button btnExportStatistics;
    }
}