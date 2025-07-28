using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 物品模型
    /// </summary>
    [Table("Items")]
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty; // 物品名称

        [Required]
        [StringLength(50)]
        public string Category { get; set; } = string.Empty; // 物品类别：医疗用品、食品、生活用品等

        [StringLength(50)]
        public string Specification { get; set; } = string.Empty; // 规格

        [StringLength(50)]
        public string Unit { get; set; } = string.Empty; // 单位：个、包、箱、瓶等

        [StringLength(50)]
        public string Manufacturer { get; set; } = string.Empty; // 制造商

        [StringLength(100)]
        public string Supplier { get; set; } = string.Empty; // 供应商

        [StringLength(20)]
        public string SupplierPhone { get; set; } = string.Empty; // 供应商联系电话

        public decimal PurchasePrice { get; set; } // 采购价格

        public int MinimumStock { get; set; } = 10; // 最低库存量

        public int WarningStock { get; set; } = 20; // 警告库存量

        [StringLength(500)]
        public string Description { get; set; } = string.Empty; // 物品描述

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        // 导航属性
        public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
    }
}