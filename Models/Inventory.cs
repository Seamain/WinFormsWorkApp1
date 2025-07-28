using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 库存模型
    /// </summary>
    [Table("Inventories")]
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }

        [Required]
        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }

        [Required]
        public int Quantity { get; set; } // 库存数量

        public DateTime? ProductionDate { get; set; } // 生产日期

        public DateTime? ExpiryDate { get; set; } // 过期日期

        [StringLength(100)]
        public string BatchNumber { get; set; } = string.Empty; // 批次号

        [StringLength(20)]
        public string Status { get; set; } = "正常"; // 状态：正常、临期、过期、损坏

        [StringLength(100)]
        public string Location { get; set; } = string.Empty; // 库位

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        public DateTime LastCheckDate { get; set; } = DateTime.Now; // 最后盘点日期

        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
    }
}