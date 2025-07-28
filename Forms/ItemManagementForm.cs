using System.Data;
using Microsoft.EntityFrameworkCore;
using WinFormsWorkApp1.Helpers;
using WinFormsWorkApp1.Models;

namespace WinFormsWorkApp1.Forms
{
    public partial class ItemManagementForm : Form
    {
        private NursingHomeDbContext _context;
        private BindingSource _facilitiesBindingSource;
        private BindingSource _warehousesBindingSource;
        private BindingSource _itemsBindingSource;
        private BindingSource _inventoriesBindingSource;
        private BindingSource _statisticsBindingSource;

        private Facility? _currentFacility;
        private Warehouse? _currentWarehouse;
        private Item? _currentItem;
        private Inventory? _currentInventory;

        public ItemManagementForm()
        {
            InitializeComponent();
            _context = new NursingHomeDbContext();
            _facilitiesBindingSource = new BindingSource();
            _warehousesBindingSource = new BindingSource();
            _itemsBindingSource = new BindingSource();
            _inventoriesBindingSource = new BindingSource();
            _statisticsBindingSource = new BindingSource();

            // 绑定事件
            this.Load += ItemManagementForm_Load;

            // 绑定设施管理事件
            if (btnAddFacility != null)
                btnAddFacility.Click += btnAddFacility_Click;
            if (btnUpdateFacility != null)
                btnUpdateFacility.Click += btnUpdateFacility_Click;
            if (btnDeleteFacility != null)
                btnDeleteFacility.Click += btnDeleteFacility_Click;
            if (btnClearFacility != null)
                btnClearFacility.Click += btnClearFacility_Click;
            if (btnSearchFacility != null)
                btnSearchFacility.Click += btnSearchFacility_Click;
            if (btnClearFacilitySearch != null)
                btnClearFacilitySearch.Click += btnClearFacilitySearch_Click;
            if (dgvFacilities != null)
                dgvFacilities.SelectionChanged += dgvFacilities_SelectionChanged;

            // 绑定仓库管理事件
            if (btnAddWarehouse != null)
                btnAddWarehouse.Click += btnAddWarehouse_Click;
            if (btnUpdateWarehouse != null)
                btnUpdateWarehouse.Click += btnUpdateWarehouse_Click;
            if (btnDeleteWarehouse != null)
                btnDeleteWarehouse.Click += btnDeleteWarehouse_Click;
            if (btnClearWarehouse != null)
                btnClearWarehouse.Click += btnClearWarehouse_Click;
            if (btnSearchWarehouse != null)
                btnSearchWarehouse.Click += btnSearchWarehouse_Click;
            if (btnClearWarehouseSearch != null)
                btnClearWarehouseSearch.Click += btnClearWarehouseSearch_Click;
            if (dgvWarehouses != null)
                dgvWarehouses.SelectionChanged += dgvWarehouses_SelectionChanged;

            // 绑定物品管理事件
            if (btnAddItem != null)
                btnAddItem.Click += btnAddItem_Click;
            if (btnUpdateItem != null)
                btnUpdateItem.Click += btnUpdateItem_Click;
            if (btnDeleteItem != null)
                btnDeleteItem.Click += btnDeleteItem_Click;
            if (btnClearItem != null)
                btnClearItem.Click += btnClearItem_Click;
            if (btnSearchItem != null)
                btnSearchItem.Click += btnSearchItem_Click;
            if (btnClearItemSearch != null)
                btnClearItemSearch.Click += btnClearItemSearch_Click;
            if (dgvItems != null)
                dgvItems.SelectionChanged += dgvItems_SelectionChanged;

            // 绑定库存管理事件
            if (btnAddInventory != null)
                btnAddInventory.Click += btnAddInventory_Click;
            if (btnUpdateInventory != null)
                btnUpdateInventory.Click += btnUpdateInventory_Click;
            if (btnDeleteInventory != null)
                btnDeleteInventory.Click += btnDeleteInventory_Click;
            if (btnClearInventory != null)
                btnClearInventory.Click += btnClearInventory_Click;
            if (btnSearchInventory != null)
                btnSearchInventory.Click += btnSearchInventory_Click;
            if (btnClearInventorySearch != null)
                btnClearInventorySearch.Click += btnClearInventorySearch_Click;
            if (dgvInventory != null)
                dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;

            // 绑定统计功能事件
            if (btnGenerateStatistics != null)
                btnGenerateStatistics.Click += btnGenerateStatistics_Click;
            if (btnExportStatistics != null)
                btnExportStatistics.Click += btnExportStatistics_Click;
        }

        private async void ItemManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 确保数据库已创建
                await _context.Database.EnsureCreatedAsync();

                // 初始化下拉框
                await InitializeComboBoxesAsync();

                // 加载数据
                await LoadFacilitiesAsync();
                await LoadWarehousesAsync();
                await LoadItemsAsync();
                await LoadInventoriesAsync();
                await LoadStatisticsAsync();

                // 绑定数据源
                if (dgvFacilities != null)
                {
                    dgvFacilities.DataSource = _facilitiesBindingSource;
                    SetupFacilitiesGridView();
                }

                if (dgvWarehouses != null)
                {
                    dgvWarehouses.DataSource = _warehousesBindingSource;
                    SetupWarehousesGridView();
                }

                if (dgvItems != null)
                {
                    dgvItems.DataSource = _itemsBindingSource;
                    SetupItemsGridView();
                }

                if (dgvInventory != null)
                {
                    dgvInventory.DataSource = _inventoriesBindingSource;
                    SetupInventoriesGridView();
                }

                if (dgvStatistics != null)
                {
                    dgvStatistics.DataSource = _statisticsBindingSource;
                    SetupStatisticsGridView();
                }

                // 设置默认值
                if (dtpFacilityPurchaseDate != null)
                    dtpFacilityPurchaseDate.Value = DateTime.Now;
                if (dtpLastMaintenance != null)
                    dtpLastMaintenance.Value = DateTime.Now;
                if (dtpNextMaintenance != null)
                    dtpNextMaintenance.Value = DateTime.Now.AddMonths(3);
                if (dtpLastInbound != null)
                    dtpLastInbound.Value = DateTime.Now;
                if (dtpLastOutbound != null)
                    dtpLastOutbound.Value = DateTime.Now;
                if (dtpStatisticsStart != null)
                    dtpStatisticsStart.Value = DateTime.Now.AddMonths(-1);
                if (dtpStatisticsEnd != null)
                    dtpStatisticsEnd.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"初始化数据失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task InitializeComboBoxesAsync()
        {
            try
            {
                // 设施类别
                var facilityCategories = new[] { "医疗设施", "娱乐设施", "生活设施", "安全设施", "其他设施" };
                if (cmbFacilityCategory != null)
                    cmbFacilityCategory.Items.AddRange(facilityCategories);
                if (cmbSearchFacilityCategory != null)
                    cmbSearchFacilityCategory.Items.AddRange(facilityCategories);

                // 设施状态
                var facilityStatuses = new[] { "正常使用", "维修中", "报废", "闲置" };
                if (cmbFacilityStatus != null)
                    cmbFacilityStatus.Items.AddRange(facilityStatuses);
                if (cmbSearchFacilityStatus != null)
                    cmbSearchFacilityStatus.Items.AddRange(facilityStatuses);

                // 仓库类型
                var warehouseTypes = new[] { "主仓库", "分仓库", "临时仓库", "冷藏仓库", "药品仓库" };
                if (cmbWarehouseType != null)
                    cmbWarehouseType.Items.AddRange(warehouseTypes);
                if (cmbSearchWarehouseType != null)
                    cmbSearchWarehouseType.Items.AddRange(warehouseTypes);

                // 仓库状态
                var warehouseStatuses = new[] { "正常", "维护中", "停用", "满库" };
                if (cmbWarehouseStatus != null)
                    cmbWarehouseStatus.Items.AddRange(warehouseStatuses);

                // 物品类别
                var itemCategories = new[] { "医疗用品", "生活用品", "办公用品", "清洁用品", "食品", "药品", "其他" };
                if (cmbItemCategory != null)
                    cmbItemCategory.Items.AddRange(itemCategories);
                if (cmbSearchItemCategory != null)
                    cmbSearchItemCategory.Items.AddRange(itemCategories);

                // 物品状态
                var itemStatuses = new[] { "正常", "停用", "缺货", "待补充" };
                if (cmbItemStatus != null)
                    cmbItemStatus.Items.AddRange(itemStatuses);

                // 统计类型
                var statisticsTypes = new[] { "设施统计", "仓库统计", "物品统计", "库存统计", "综合统计" };
                if (cmbStatisticsType != null)
                    cmbStatisticsType.Items.AddRange(statisticsTypes);

                // 加载物品和仓库数据到下拉框
                var items = await _context.Items.ToListAsync();
                if (cmbInventoryItem != null)
                {
                    cmbInventoryItem.DataSource = items;
                    cmbInventoryItem.DisplayMember = "Name";
                    cmbInventoryItem.ValueMember = "Id";
                    cmbInventoryItem.SelectedIndex = -1;
                }
                if (cmbSearchInventoryItem != null)
                {
                    cmbSearchInventoryItem.DataSource = items.ToList();
                    cmbSearchInventoryItem.DisplayMember = "Name";
                    cmbSearchInventoryItem.ValueMember = "Id";
                    cmbSearchInventoryItem.SelectedIndex = -1;
                }

                var warehouses = await _context.Warehouses.ToListAsync();
                if (cmbInventoryWarehouse != null)
                {
                    cmbInventoryWarehouse.DataSource = warehouses;
                    cmbInventoryWarehouse.DisplayMember = "Name";
                    cmbInventoryWarehouse.ValueMember = "Id";
                    cmbInventoryWarehouse.SelectedIndex = -1;
                }
                if (cmbSearchInventoryWarehouse != null)
                {
                    cmbSearchInventoryWarehouse.DataSource = warehouses.ToList();
                    cmbSearchInventoryWarehouse.DisplayMember = "Name";
                    cmbSearchInventoryWarehouse.ValueMember = "Id";
                    cmbSearchInventoryWarehouse.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"初始化下拉框失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupFacilitiesGridView()
        {
            if (dgvFacilities?.Columns != null && dgvFacilities.Columns.Count > 0)
            {
                try
                {
                    // 隐藏ID列
                    if (dgvFacilities.Columns["Id"] != null)
                        dgvFacilities.Columns["Id"].Visible = false;

                    // 设置列标题
                    if (dgvFacilities.Columns["Name"] != null)
                        dgvFacilities.Columns["Name"].HeaderText = "设施名称";
                    if (dgvFacilities.Columns["Category"] != null)
                        dgvFacilities.Columns["Category"].HeaderText = "类别";
                    if (dgvFacilities.Columns["Location"] != null)
                        dgvFacilities.Columns["Location"].HeaderText = "位置";
                    if (dgvFacilities.Columns["Status"] != null)
                        dgvFacilities.Columns["Status"].HeaderText = "状态";
                    if (dgvFacilities.Columns["PurchasePrice"] != null)
                        dgvFacilities.Columns["PurchasePrice"].HeaderText = "采购价格";
                    if (dgvFacilities.Columns["PurchaseDate"] != null)
                        dgvFacilities.Columns["PurchaseDate"].HeaderText = "采购日期";
                    if (dgvFacilities.Columns["Manufacturer"] != null)
                        dgvFacilities.Columns["Manufacturer"].HeaderText = "制造商"; if (dgvFacilities.Columns["Model"] != null)
                        dgvFacilities.Columns["Model"].HeaderText = "型号";
                    if (dgvFacilities.Columns["Description"] != null)
                        dgvFacilities.Columns["Description"].HeaderText = "描述";
                    if (dgvFacilities.Columns["CreateTime"] != null)
                        dgvFacilities.Columns["CreateTime"].HeaderText = "创建时间";
                    if (dgvFacilities.Columns["UpdateTime"] != null)
                        dgvFacilities.Columns["UpdateTime"].HeaderText = "更新时间";
                }
                catch (Exception ex)
                {
                    // 忽略列设置错误
                }
            }
        }

        private void SetupWarehousesGridView()
        {
            if (dgvWarehouses?.Columns != null && dgvWarehouses.Columns.Count > 0)
            {
                try
                {
                    if (dgvWarehouses.Columns["Id"] != null)
                        dgvWarehouses.Columns["Id"].Visible = false;
                    if (dgvWarehouses.Columns["Name"] != null)
                        dgvWarehouses.Columns["Name"].HeaderText = "仓库名称";
                    if (dgvWarehouses.Columns["Location"] != null)
                        dgvWarehouses.Columns["Location"].HeaderText = "位置";
                    if (dgvWarehouses.Columns["Capacity"] != null)
                        dgvWarehouses.Columns["Capacity"].HeaderText = "容量"; if (dgvWarehouses.Columns["Manager"] != null)
                        dgvWarehouses.Columns["Manager"].HeaderText = "管理员";
                    if (dgvWarehouses.Columns["Status"] != null)
                        dgvWarehouses.Columns["Status"].HeaderText = "状态";
                    if (dgvWarehouses.Columns["Description"] != null)
                        dgvWarehouses.Columns["Description"].HeaderText = "描述";
                    if (dgvWarehouses.Columns["CreateTime"] != null)
                        dgvWarehouses.Columns["CreateTime"].HeaderText = "创建时间";
                }
                catch (Exception ex)
                {
                    // 忽略列设置错误
                }
            }
        }

        private void SetupItemsGridView()
        {
            if (dgvItems?.Columns != null && dgvItems.Columns.Count > 0)
            {
                try
                {
                    if (dgvItems.Columns["Id"] != null)
                        dgvItems.Columns["Id"].Visible = false;
                    if (dgvItems.Columns["Name"] != null)
                        dgvItems.Columns["Name"].HeaderText = "物品名称";
                    if (dgvItems.Columns["Category"] != null)
                        dgvItems.Columns["Category"].HeaderText = "类别";
                    if (dgvItems.Columns["Unit"] != null)
                        dgvItems.Columns["Unit"].HeaderText = "单位";
                    if (dgvItems.Columns["Price"] != null)
                        dgvItems.Columns["Price"].HeaderText = "单价"; if (dgvItems.Columns["Supplier"] != null)
                        dgvItems.Columns["Supplier"].HeaderText = "供应商";
                    if (dgvItems.Columns["MinStock"] != null)
                        dgvItems.Columns["MinStock"].HeaderText = "最小库存";
                    if (dgvItems.Columns["MaxStock"] != null)
                        dgvItems.Columns["MaxStock"].HeaderText = "最大库存";
                    if (dgvItems.Columns["Description"] != null)
                        dgvItems.Columns["Description"].HeaderText = "描述";
                    if (dgvItems.Columns["IsActive"] != null)
                        dgvItems.Columns["IsActive"].HeaderText = "是否启用";
                }
                catch (Exception ex)
                {
                    // 忽略列设置错误
                }
            }
        }
        private void SetupInventoriesGridView()
        {
            if (dgvInventory?.Columns != null && dgvInventory.Columns.Count > 0)
            {
                try
                {
                    if (dgvInventory.Columns["Id"] != null)
                        dgvInventory.Columns["Id"].Visible = false;
                    if (dgvInventory.Columns["ItemId"] != null)
                        dgvInventory.Columns["ItemId"].Visible = false;
                    if (dgvInventory.Columns["WarehouseId"] != null)
                        dgvInventory.Columns["WarehouseId"].Visible = false;
                    if (dgvInventory.Columns["物品名称"] != null)
                        dgvInventory.Columns["物品名称"].HeaderText = "物品名称";
                    if (dgvInventory.Columns["仓库名称"] != null)
                        dgvInventory.Columns["仓库名称"].HeaderText = "仓库名称";
                    if (dgvInventory.Columns["数量"] != null)
                        dgvInventory.Columns["数量"].HeaderText = "数量";
                    if (dgvInventory.Columns["库位"] != null)
                        dgvInventory.Columns["库位"].HeaderText = "库位";
                    if (dgvInventory.Columns["状态"] != null)
                        dgvInventory.Columns["状态"].HeaderText = "状态";
                    if (dgvInventory.Columns["批次号"] != null)
                        dgvInventory.Columns["批次号"].HeaderText = "批次号";
                    if (dgvInventory.Columns["生产日期"] != null)
                        dgvInventory.Columns["生产日期"].HeaderText = "生产日期";
                    if (dgvInventory.Columns["最后盘点日期"] != null)
                        dgvInventory.Columns["最后盘点日期"].HeaderText = "最后盘点日期";
                    if (dgvInventory.Columns["备注"] != null)
                        dgvInventory.Columns["备注"].HeaderText = "备注";
                    if (dgvInventory.Columns["创建时间"] != null)
                        dgvInventory.Columns["创建时间"].HeaderText = "创建时间";
                    if (dgvInventory.Columns["更新时间"] != null)
                        dgvInventory.Columns["更新时间"].HeaderText = "更新时间";
                }
                catch (Exception ex)
                {
                    // 忽略列设置错误
                }
            }
        }

        private void SetupStatisticsGridView()
        {
            if (dgvStatistics?.Columns != null)
            {
                try
                {
                    dgvStatistics.AutoGenerateColumns = true;
                }
                catch (Exception ex)
                {
                    // 忽略列设置错误
                }
            }
        }

        #region 设施管理
        private async Task LoadFacilitiesAsync()
        {
            try
            {
                var facilities = await _context.Facilities
                    .OrderByDescending(f => f.Id)
                    .ToListAsync();

                _facilitiesBindingSource.DataSource = facilities;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载设施信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddFacility_Click(object sender, EventArgs e)
        {
            if (!ValidateFacilityInput())
                return;

            try
            {
                var facility = new Facility
                {
                    Name = txtFacilityName?.Text?.Trim() ?? "",
                    Category = cmbFacilityCategory?.Text ?? "",
                    Location = txtFacilityLocation?.Text?.Trim() ?? "",
                    Description = txtFacilityDescription?.Text?.Trim() ?? "",
                    PurchaseDate = dtpFacilityPurchaseDate?.Value ?? DateTime.Now,
                    PurchasePrice = numFacilityPrice?.Value ?? 0,
                    Manufacturer = txtFacilityManufacturer?.Text?.Trim() ?? "",
                    Model = txtFacilityModel?.Text?.Trim() ?? "",
                    Status = cmbFacilityStatus?.Text ?? "",
                    MaintenanceRecord = txtMaintenanceRecord?.Text?.Trim() ?? "",
                    LastMaintenanceDate = dtpLastMaintenance?.Value,
                    NextMaintenanceDate = dtpNextMaintenance?.Value,
                    Notes = txtFacilityNotes?.Text?.Trim() ?? "",
                    CreateTime = DateTime.Now
                };

                _context.Facilities.Add(facility);
                await _context.SaveChangesAsync();

                MessageBox.Show("设施信息添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFacilityForm();
                await LoadFacilitiesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加设施信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdateFacility_Click(object sender, EventArgs e)
        {
            if (_currentFacility == null)
            {
                MessageBox.Show("请先选择要修改的设施信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFacilityInput())
                return;

            try
            {
                var facility = await _context.Facilities.FindAsync(_currentFacility.Id);
                if (facility == null)
                {
                    MessageBox.Show("设施信息不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                facility.Name = txtFacilityName?.Text?.Trim() ?? "";
                facility.Category = cmbFacilityCategory?.Text ?? "";
                facility.Location = txtFacilityLocation?.Text?.Trim() ?? "";
                facility.Description = txtFacilityDescription?.Text?.Trim() ?? "";
                facility.PurchaseDate = dtpFacilityPurchaseDate?.Value ?? DateTime.Now;
                facility.PurchasePrice = numFacilityPrice?.Value ?? 0;
                facility.Manufacturer = txtFacilityManufacturer?.Text?.Trim() ?? "";
                facility.Model = txtFacilityModel?.Text?.Trim() ?? "";
                facility.Status = cmbFacilityStatus?.Text ?? "";
                facility.MaintenanceRecord = txtMaintenanceRecord?.Text?.Trim() ?? "";
                facility.LastMaintenanceDate = dtpLastMaintenance?.Value;
                facility.NextMaintenanceDate = dtpNextMaintenance?.Value;
                facility.Notes = txtFacilityNotes?.Text?.Trim() ?? "";
                facility.UpdateTime = DateTime.Now;

                await _context.SaveChangesAsync();

                MessageBox.Show("设施信息修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFacilityForm();
                await LoadFacilitiesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改设施信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteFacility_Click(object sender, EventArgs e)
        {
            if (_currentFacility == null)
            {
                MessageBox.Show("请先选择要删除的设施信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("确定要删除该设施信息吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            try
            {
                var facility = await _context.Facilities.FindAsync(_currentFacility.Id);
                if (facility == null)
                {
                    MessageBox.Show("设施信息不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _context.Facilities.Remove(facility);
                await _context.SaveChangesAsync();

                MessageBox.Show("设施信息删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFacilityForm();
                await LoadFacilitiesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除设施信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFacility_Click(object sender, EventArgs e)
        {
            ClearFacilityForm();
        }

        private async void btnSearchFacility_Click(object sender, EventArgs e)
        {
            try
            {
                var query = _context.Facilities.AsQueryable();

                if (txtSearchFacilityName != null && !string.IsNullOrWhiteSpace(txtSearchFacilityName.Text))
                {
                    var name = txtSearchFacilityName.Text.Trim();
                    query = query.Where(f => f.Name.Contains(name));
                }

                if (cmbSearchFacilityCategory != null && cmbSearchFacilityCategory.SelectedIndex >= 0)
                {
                    var category = cmbSearchFacilityCategory.Text;
                    query = query.Where(f => f.Category == category);
                }

                if (cmbSearchFacilityStatus != null && cmbSearchFacilityStatus.SelectedIndex >= 0)
                {
                    var status = cmbSearchFacilityStatus.Text;
                    query = query.Where(f => f.Status == status);
                }

                var facilities = await query.OrderByDescending(f => f.Id).ToListAsync();
                _facilitiesBindingSource.DataSource = facilities;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索设施信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnClearFacilitySearch_Click(object sender, EventArgs e)
        {
            if (txtSearchFacilityName != null)
                txtSearchFacilityName.Clear();
            if (cmbSearchFacilityCategory != null)
                cmbSearchFacilityCategory.SelectedIndex = -1;
            if (cmbSearchFacilityStatus != null)
                cmbSearchFacilityStatus.SelectedIndex = -1;
            await LoadFacilitiesAsync();
        }

        private void dgvFacilities_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFacilities?.CurrentRow?.DataBoundItem is Facility facility)
            {
                _currentFacility = facility;
                LoadFacilityToForm(facility);
            }
        }

        private void LoadFacilityToForm(Facility facility)
        {
            if (txtFacilityName != null)
                txtFacilityName.Text = facility.Name ?? "";
            if (cmbFacilityCategory != null)
                cmbFacilityCategory.Text = facility.Category ?? "";
            if (txtFacilityLocation != null)
                txtFacilityLocation.Text = facility.Location ?? "";
            if (txtFacilityDescription != null)
                txtFacilityDescription.Text = facility.Description ?? "";
            if (dtpFacilityPurchaseDate != null)
                dtpFacilityPurchaseDate.Value = facility.PurchaseDate;
            if (numFacilityPrice != null)
                numFacilityPrice.Value = facility.PurchasePrice;
            if (txtFacilityManufacturer != null)
                txtFacilityManufacturer.Text = facility.Manufacturer ?? "";
            if (txtFacilityModel != null)
                txtFacilityModel.Text = facility.Model ?? "";
            if (cmbFacilityStatus != null)
                cmbFacilityStatus.Text = facility.Status ?? "";
            if (txtMaintenanceRecord != null)
                txtMaintenanceRecord.Text = facility.MaintenanceRecord ?? "";
            if (dtpLastMaintenance != null)
                dtpLastMaintenance.Value = facility.LastMaintenanceDate ?? DateTime.Now;
            if (dtpNextMaintenance != null)
                dtpNextMaintenance.Value = facility.NextMaintenanceDate ?? DateTime.Now.AddMonths(3);
            if (txtFacilityNotes != null)
                txtFacilityNotes.Text = facility.Notes ?? "";
        }

        private void ClearFacilityForm()
        {
            if (txtFacilityName != null)
                txtFacilityName.Clear();
            if (cmbFacilityCategory != null)
                cmbFacilityCategory.SelectedIndex = -1;
            if (txtFacilityLocation != null)
                txtFacilityLocation.Clear();
            if (txtFacilityDescription != null)
                txtFacilityDescription.Clear();
            if (dtpFacilityPurchaseDate != null)
                dtpFacilityPurchaseDate.Value = DateTime.Now;
            if (numFacilityPrice != null)
                numFacilityPrice.Value = 0;
            if (txtFacilityManufacturer != null)
                txtFacilityManufacturer.Clear();
            if (txtFacilityModel != null)
                txtFacilityModel.Clear();
            if (cmbFacilityStatus != null)
                cmbFacilityStatus.SelectedIndex = -1;
            if (txtMaintenanceRecord != null)
                txtMaintenanceRecord.Clear();
            if (dtpLastMaintenance != null)
                dtpLastMaintenance.Value = DateTime.Now;
            if (dtpNextMaintenance != null)
                dtpNextMaintenance.Value = DateTime.Now.AddMonths(3);
            if (txtFacilityNotes != null)
                txtFacilityNotes.Clear();
            _currentFacility = null;
        }

        private bool ValidateFacilityInput()
        {
            if (txtFacilityName == null || string.IsNullOrWhiteSpace(txtFacilityName.Text))
            {
                MessageBox.Show("请输入设施名称！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFacilityName?.Focus();
                return false;
            }

            if (cmbFacilityCategory == null || string.IsNullOrWhiteSpace(cmbFacilityCategory.Text))
            {
                MessageBox.Show("请选择设施类别！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFacilityCategory?.Focus();
                return false;
            }

            if (cmbFacilityStatus == null || string.IsNullOrWhiteSpace(cmbFacilityStatus.Text))
            {
                MessageBox.Show("请选择设施状态！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFacilityStatus?.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region 仓库管理
        private async Task LoadWarehousesAsync()
        {
            try
            {
                var warehouses = await _context.Warehouses
                    .OrderByDescending(w => w.Id)
                    .ToListAsync();

                _warehousesBindingSource.DataSource = warehouses;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载仓库信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            if (!ValidateWarehouseInput())
                return;

            try
            {
                var warehouse = new Warehouse
                {
                    Name = txtWarehouseName?.Text?.Trim() ?? "",
                    Location = txtWarehouseLocation?.Text?.Trim() ?? "",
                    Capacity = (int)(numWarehouseCapacity?.Value ?? 0),
                    Manager = txtWarehouseManager?.Text?.Trim() ?? "",
                    Description = txtWarehouseDescription?.Text?.Trim() ?? "",
                    CreateTime = DateTime.Now
                };

                _context.Warehouses.Add(warehouse);
                await _context.SaveChangesAsync();

                MessageBox.Show("仓库信息添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearWarehouseForm();
                await LoadWarehousesAsync();
                await InitializeComboBoxesAsync(); // 重新初始化下拉框
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加仓库信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdateWarehouse_Click(object sender, EventArgs e)
        {
            if (_currentWarehouse == null)
            {
                MessageBox.Show("请先选择要修改的仓库信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateWarehouseInput())
                return;

            try
            {
                var warehouse = await _context.Warehouses.FindAsync(_currentWarehouse.Id);
                if (warehouse == null)
                {
                    MessageBox.Show("仓库信息不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                warehouse.Name = txtWarehouseName?.Text?.Trim() ?? "";
                warehouse.Location = txtWarehouseLocation?.Text?.Trim() ?? "";
                warehouse.Capacity = (int)(numWarehouseCapacity?.Value ?? 0);
                warehouse.Manager = txtWarehouseManager?.Text?.Trim() ?? "";
                warehouse.Description = txtWarehouseDescription?.Text?.Trim() ?? "";
                warehouse.UpdateTime = DateTime.Now;

                await _context.SaveChangesAsync();

                MessageBox.Show("仓库信息修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearWarehouseForm();
                await LoadWarehousesAsync();
                await InitializeComboBoxesAsync(); // 重新初始化下拉框
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改仓库信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteWarehouse_Click(object sender, EventArgs e)
        {
            if (_currentWarehouse == null)
            {
                MessageBox.Show("请先选择要删除的仓库信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("确定要删除该仓库信息吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            try
            {
                var warehouse = await _context.Warehouses.FindAsync(_currentWarehouse.Id);
                if (warehouse == null)
                {
                    MessageBox.Show("仓库信息不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _context.Warehouses.Remove(warehouse);
                await _context.SaveChangesAsync();

                MessageBox.Show("仓库信息删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearWarehouseForm();
                await LoadWarehousesAsync();
                await InitializeComboBoxesAsync(); // 重新初始化下拉框
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除仓库信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearWarehouse_Click(object sender, EventArgs e)
        {
            ClearWarehouseForm();
        }

        private async void btnSearchWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                var query = _context.Warehouses.AsQueryable();

                if (txtSearchWarehouseName != null && !string.IsNullOrWhiteSpace(txtSearchWarehouseName.Text))
                {
                    var name = txtSearchWarehouseName.Text.Trim();
                    query = query.Where(w => w.Name.Contains(name));
                }

                if (cmbSearchWarehouseType != null && cmbSearchWarehouseType.SelectedIndex >= 0)
                {
                    var type = cmbSearchWarehouseType.Text;
                    // 注意：仓库实体可能没有Type属性，这里可能需要调整
                }

                var warehouses = await query.OrderByDescending(w => w.Id).ToListAsync();
                _warehousesBindingSource.DataSource = warehouses;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索仓库信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnClearWarehouseSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchWarehouseName != null)
                txtSearchWarehouseName.Clear();
            if (cmbSearchWarehouseType != null)
                cmbSearchWarehouseType.SelectedIndex = -1;
            await LoadWarehousesAsync();
        }

        private void dgvWarehouses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWarehouses?.CurrentRow?.DataBoundItem is Warehouse warehouse)
            {
                _currentWarehouse = warehouse;
                LoadWarehouseToForm(warehouse);
            }
        }

        private void LoadWarehouseToForm(Warehouse warehouse)
        {
            if (txtWarehouseName != null)
                txtWarehouseName.Text = warehouse.Name ?? "";
            if (txtWarehouseLocation != null)
                txtWarehouseLocation.Text = warehouse.Location ?? "";
            if (numWarehouseCapacity != null)
                numWarehouseCapacity.Value = warehouse.Capacity;
            if (txtWarehouseManager != null)
                txtWarehouseManager.Text = warehouse.Manager ?? "";
            if (txtWarehouseDescription != null)
                txtWarehouseDescription.Text = warehouse.Description ?? "";
        }

        private void ClearWarehouseForm()
        {
            if (txtWarehouseName != null)
                txtWarehouseName.Clear();
            if (txtWarehouseLocation != null)
                txtWarehouseLocation.Clear();
            if (cmbWarehouseType != null)
                cmbWarehouseType.SelectedIndex = -1;
            if (numWarehouseCapacity != null)
                numWarehouseCapacity.Value = 0;
            if (txtWarehouseManager != null)
                txtWarehouseManager.Clear();
            if (cmbWarehouseStatus != null)
                cmbWarehouseStatus.SelectedIndex = -1;
            if (txtWarehouseDescription != null)
                txtWarehouseDescription.Clear();
            if (txtWarehouseNotes != null)
                txtWarehouseNotes.Clear();
            _currentWarehouse = null;
        }

        private bool ValidateWarehouseInput()
        {
            if (txtWarehouseName == null || string.IsNullOrWhiteSpace(txtWarehouseName.Text))
            {
                MessageBox.Show("请输入仓库名称！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWarehouseName?.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region 物品管理
        private async Task LoadItemsAsync()
        {
            try
            {
                var items = await _context.Items
                    .OrderByDescending(i => i.Id)
                    .ToListAsync();

                _itemsBindingSource.DataSource = items;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载物品信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!ValidateItemInput())
                return;

            try
            {
                var item = new Item
                {
                    Name = txtItemName?.Text?.Trim() ?? "",
                    Category = cmbItemCategory?.Text ?? "",
                    Unit = txtItemUnit?.Text?.Trim() ?? "",
                    Supplier = txtItemSupplier?.Text?.Trim() ?? "",
                    Description = txtItemDescription?.Text?.Trim() ?? "",
                    CreateTime = DateTime.Now
                };

                _context.Items.Add(item);
                await _context.SaveChangesAsync();

                MessageBox.Show("物品信息添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearItemForm();
                await LoadItemsAsync();
                await InitializeComboBoxesAsync(); // 重新初始化下拉框以包含新物品
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加物品信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (_currentItem == null)
            {
                MessageBox.Show("请先选择要修改的物品信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateItemInput())
                return;

            try
            {
                var item = await _context.Items.FindAsync(_currentItem.Id);
                if (item == null)
                {
                    MessageBox.Show("物品信息不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                item.Name = txtItemName?.Text?.Trim() ?? "";
                item.Category = cmbItemCategory?.Text ?? "";
                item.Unit = txtItemUnit?.Text?.Trim() ?? "";
                item.Supplier = txtItemSupplier?.Text?.Trim() ?? "";
                item.Description = txtItemDescription?.Text?.Trim() ?? "";
                item.UpdateTime = DateTime.Now;

                await _context.SaveChangesAsync();

                MessageBox.Show("物品信息修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearItemForm();
                await LoadItemsAsync();
                await InitializeComboBoxesAsync(); // 重新初始化下拉框
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改物品信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (_currentItem == null)
            {
                MessageBox.Show("请先选择要删除的物品信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("确定要删除该物品信息吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            try
            {
                var item = await _context.Items.FindAsync(_currentItem.Id);
                if (item == null)
                {
                    MessageBox.Show("物品信息不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _context.Items.Remove(item);
                await _context.SaveChangesAsync();

                MessageBox.Show("物品信息删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearItemForm();
                await LoadItemsAsync();
                await InitializeComboBoxesAsync(); // 重新初始化下拉框
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除物品信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            ClearItemForm();
        }

        private async void btnSearchItem_Click(object sender, EventArgs e)
        {
            try
            {
                var query = _context.Items.AsQueryable();

                if (txtSearchItemName != null && !string.IsNullOrWhiteSpace(txtSearchItemName.Text))
                {
                    var name = txtSearchItemName.Text.Trim();
                    query = query.Where(i => i.Name.Contains(name));
                }

                if (cmbSearchItemCategory != null && cmbSearchItemCategory.SelectedIndex >= 0)
                {
                    var category = cmbSearchItemCategory.Text;
                    query = query.Where(i => i.Category == category);
                }

                var items = await query.OrderByDescending(i => i.Id).ToListAsync();
                _itemsBindingSource.DataSource = items;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索物品信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnClearItemSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchItemName != null)
                txtSearchItemName.Clear();
            if (cmbSearchItemCategory != null)
                cmbSearchItemCategory.SelectedIndex = -1;
            await LoadItemsAsync();
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems?.CurrentRow?.DataBoundItem is Item item)
            {
                _currentItem = item;
                LoadItemToForm(item);
            }
        }

        private void LoadItemToForm(Item item)
        {
            if (txtItemName != null)
                txtItemName.Text = item.Name ?? "";
            if (cmbItemCategory != null)
                cmbItemCategory.Text = item.Category ?? "";
            if (txtItemCode != null)
                txtItemCode.Text = ""; // 物品编码可能需要从其他地方获取
            if (txtItemDescription != null)
                txtItemDescription.Text = item.Description ?? "";
            if (txtItemUnit != null)
                txtItemUnit.Text = item.Unit ?? "";
            if (txtItemSupplier != null)
                txtItemSupplier.Text = item.Supplier ?? "";
            if (txtItemNotes != null)
                txtItemNotes.Text = ""; // 备注可能需要从其他地方获取
        }

        private void ClearItemForm()
        {
            if (txtItemName != null)
                txtItemName.Clear();
            if (cmbItemCategory != null)
                cmbItemCategory.SelectedIndex = -1;
            if (txtItemCode != null)
                txtItemCode.Clear();
            if (txtItemDescription != null)
                txtItemDescription.Clear();
            if (txtItemUnit != null)
                txtItemUnit.Clear();
            if (numItemPrice != null)
                numItemPrice.Value = 0;
            if (txtItemSupplier != null)
                txtItemSupplier.Clear();
            if (cmbItemStatus != null)
                cmbItemStatus.SelectedIndex = -1;
            if (numMinStock != null)
                numMinStock.Value = 0;
            if (numMaxStock != null)
                numMaxStock.Value = 0;
            if (txtItemNotes != null)
                txtItemNotes.Clear();
            _currentItem = null;
        }

        private bool ValidateItemInput()
        {
            if (txtItemName == null || string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("请输入物品名称！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName?.Focus();
                return false;
            }

            if (cmbItemCategory == null || string.IsNullOrWhiteSpace(cmbItemCategory.Text))
            {
                MessageBox.Show("请选择物品类别！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbItemCategory?.Focus();
                return false;
            }

            if (txtItemUnit == null || string.IsNullOrWhiteSpace(txtItemUnit.Text))
            {
                MessageBox.Show("请输入物品单位！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemUnit?.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region 库存管理        
        private async Task LoadInventoriesAsync()
        {
            try
            {
                var inventories = await _context.Inventories
                    .Include(i => i.Item)
                    .Include(i => i.Warehouse)
                    .OrderByDescending(i => i.Id)
                    .Select(i => new
                    {
                        Id = i.Id,
                        ItemId = i.ItemId,
                        WarehouseId = i.WarehouseId,
                        物品名称 = i.Item.Name,
                        仓库名称 = i.Warehouse.Name,
                        数量 = i.Quantity,
                        库位 = i.Location,
                        状态 = i.Status,
                        批次号 = i.BatchNumber,
                        生产日期 = i.ProductionDate,
                        最后盘点日期 = i.LastCheckDate,
                        备注 = i.Notes,
                        创建时间 = i.CreateTime,
                        更新时间 = i.UpdateTime
                    })
                    .ToListAsync();

                _inventoriesBindingSource.DataSource = inventories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载库存信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddInventory_Click(object sender, EventArgs e)
        {
            if (!ValidateInventoryInput())
                return;

            try
            {
                var inventory = new Inventory
                {
                    ItemId = (int)(cmbInventoryItem?.SelectedValue ?? 0),
                    WarehouseId = (int)(cmbInventoryWarehouse?.SelectedValue ?? 0),
                    Quantity = (int)(numCurrentStock?.Value ?? 0),
                    Notes = txtInventoryNotes?.Text?.Trim() ?? "",
                    CreateTime = DateTime.Now
                };

                _context.Inventories.Add(inventory);
                await _context.SaveChangesAsync();

                MessageBox.Show("库存信息添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInventoryForm();
                await LoadInventoriesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加库存信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            if (_currentInventory == null)
            {
                MessageBox.Show("请先选择要修改的库存信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInventoryInput())
                return;

            try
            {
                var inventory = await _context.Inventories.FindAsync(_currentInventory.Id);
                if (inventory == null)
                {
                    MessageBox.Show("库存信息不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                inventory.ItemId = (int)(cmbInventoryItem?.SelectedValue ?? 0);
                inventory.WarehouseId = (int)(cmbInventoryWarehouse?.SelectedValue ?? 0);
                inventory.Quantity = (int)(numCurrentStock?.Value ?? 0);
                inventory.Notes = txtInventoryNotes?.Text?.Trim() ?? "";
                inventory.UpdateTime = DateTime.Now;

                await _context.SaveChangesAsync();

                MessageBox.Show("库存信息修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInventoryForm();
                await LoadInventoriesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改库存信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            if (_currentInventory == null)
            {
                MessageBox.Show("请先选择要删除的库存信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("确定要删除该库存信息吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            try
            {
                var inventory = await _context.Inventories.FindAsync(_currentInventory.Id);
                if (inventory == null)
                {
                    MessageBox.Show("库存信息不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _context.Inventories.Remove(inventory);
                await _context.SaveChangesAsync();

                MessageBox.Show("库存信息删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInventoryForm();
                await LoadInventoriesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除库存信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearInventory_Click(object sender, EventArgs e)
        {
            ClearInventoryForm();
        }

        private async void btnSearchInventory_Click(object sender, EventArgs e)
        {
            try
            {
                var query = _context.Inventories
                    .Include(i => i.Item)
                    .Include(i => i.Warehouse)
                    .AsQueryable();

                if (cmbSearchInventoryItem != null && cmbSearchInventoryItem.SelectedValue != null)
                {
                    var itemId = (int)cmbSearchInventoryItem.SelectedValue;
                    query = query.Where(i => i.ItemId == itemId);
                }

                if (cmbSearchInventoryWarehouse != null && cmbSearchInventoryWarehouse.SelectedValue != null)
                {
                    var warehouseId = (int)cmbSearchInventoryWarehouse.SelectedValue;
                    query = query.Where(i => i.WarehouseId == warehouseId);
                }

                var inventories = await query.OrderByDescending(i => i.Id).ToListAsync();
                _inventoriesBindingSource.DataSource = inventories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜索库存信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnClearInventorySearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchInventoryItem != null)
                cmbSearchInventoryItem.SelectedIndex = -1;
            if (cmbSearchInventoryWarehouse != null)
                cmbSearchInventoryWarehouse.SelectedIndex = -1;
            await LoadInventoriesAsync();
        }
        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventory?.CurrentRow?.DataBoundItem != null)
            {
                // 由于现在使用匿名对象，我们需要通过反射获取ID值
                var dataObject = dgvInventory.CurrentRow.DataBoundItem;
                var idProperty = dataObject.GetType().GetProperty("Id");
                var itemIdProperty = dataObject.GetType().GetProperty("ItemId");
                var warehouseIdProperty = dataObject.GetType().GetProperty("WarehouseId");

                if (idProperty != null && itemIdProperty != null && warehouseIdProperty != null)
                {
                    var id = (int)idProperty.GetValue(dataObject)!;
                    var itemId = (int)itemIdProperty.GetValue(dataObject)!;
                    var warehouseId = (int)warehouseIdProperty.GetValue(dataObject)!;

                    // 从数据库重新加载实际的Inventory对象
                    var inventory = _context.Inventories.FirstOrDefault(i => i.Id == id);
                    if (inventory != null)
                    {
                        _currentInventory = inventory;
                        LoadInventoryToForm(inventory);
                    }
                }
            }
        }

        private void LoadInventoryToForm(Inventory inventory)
        {
            if (cmbInventoryItem != null)
                cmbInventoryItem.SelectedValue = inventory.ItemId;
            if (cmbInventoryWarehouse != null)
                cmbInventoryWarehouse.SelectedValue = inventory.WarehouseId;
            if (numCurrentStock != null)
                numCurrentStock.Value = inventory.Quantity;
            if (txtInventoryNotes != null)
                txtInventoryNotes.Text = inventory.Notes ?? "";
        }

        private void ClearInventoryForm()
        {
            if (cmbInventoryItem != null)
                cmbInventoryItem.SelectedIndex = -1;
            if (cmbInventoryWarehouse != null)
                cmbInventoryWarehouse.SelectedIndex = -1;
            if (numCurrentStock != null)
                numCurrentStock.Value = 0;
            if (dtpLastInbound != null)
                dtpLastInbound.Value = DateTime.Now;
            if (dtpLastOutbound != null)
                dtpLastOutbound.Value = DateTime.Now;
            if (txtInventoryNotes != null)
                txtInventoryNotes.Clear();
            _currentInventory = null;
        }

        private bool ValidateInventoryInput()
        {
            if (cmbInventoryItem == null || cmbInventoryItem.SelectedValue == null)
            {
                MessageBox.Show("请选择物品！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbInventoryItem?.Focus();
                return false;
            }

            if (cmbInventoryWarehouse == null || cmbInventoryWarehouse.SelectedValue == null)
            {
                MessageBox.Show("请选择仓库！", "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbInventoryWarehouse?.Focus();
                return false;
            }

            return true;
        }
        #endregion

        #region 统计功能
        private async Task LoadStatisticsAsync()
        {
            try
            {
                var statistics = new List<object>();

                // 设施统计
                var facilityStats = await _context.Facilities
                    .GroupBy(f => f.Category)
                    .Select(g => new { 类别 = g.Key, 数量 = g.Count(), 类型 = "设施" })
                    .ToListAsync();

                // 物品统计
                var itemStats = await _context.Items
                    .GroupBy(i => i.Category)
                    .Select(g => new { 类别 = g.Key, 数量 = g.Count(), 类型 = "物品" })
                    .ToListAsync();

                // 库存统计
                var inventoryStats = await _context.Inventories
                    .Include(i => i.Item)
                    .GroupBy(i => i.Item.Category)
                    .Select(g => new { 类别 = g.Key, 数量 = g.Sum(x => x.Quantity), 类型 = "库存" })
                    .ToListAsync();

                statistics.AddRange(facilityStats);
                statistics.AddRange(itemStats);
                statistics.AddRange(inventoryStats);

                _statisticsBindingSource.DataSource = statistics;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载统计信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGenerateStatistics_Click(object sender, EventArgs e)
        {
            await LoadStatisticsAsync();
        }

        private void btnExportStatistics_Click(object sender, EventArgs e)
        {
            try
            {
                // 简单的导出功能，可以根据需要扩展
                MessageBox.Show("导出功能正在开发中...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"导出统计信息失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

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