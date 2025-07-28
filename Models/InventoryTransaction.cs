using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 库存交易记录模型
    /// </summary>
    [Table("InventoryTransactions")]
    public class InventoryTransaction
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
        [StringLength(20)]
        public string TransactionType { get; set; } = string.Empty; // 交易类型：入库、出库、调拨、盘点调整

        [Required]
        public int Quantity { get; set; } // 交易数量

        [Required]
        public DateTime TransactionDate { get; set; } = DateTime.Now; // 交易日期

        [StringLength(50)]
        public string Operator { get; set; } = string.Empty; // 操作人

        [StringLength(100)]
        public string Source { get; set; } = string.Empty; // 来源/目的地

        [StringLength(100)]
        public string BatchNumber { get; set; } = string.Empty; // 批次号

        [StringLength(500)]
        public string Reason { get; set; } = string.Empty; // 交易原因

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}