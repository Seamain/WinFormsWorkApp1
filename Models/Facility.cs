using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 养老院设施模型
    /// </summary>
    [Table("Facilities")]
    public class Facility
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty; // 设施名称

        [Required]
        [StringLength(50)]
        public string Category { get; set; } = string.Empty; // 设施类别：医疗设施、娱乐设施、生活设施等

        [StringLength(50)]
        public string Location { get; set; } = string.Empty; // 设施位置

        [StringLength(500)]
        public string Description { get; set; } = string.Empty; // 设施描述

        [Required]
        public DateTime PurchaseDate { get; set; } // 购买日期

        public decimal PurchasePrice { get; set; } // 购买价格

        [StringLength(50)]
        public string Manufacturer { get; set; } = string.Empty; // 制造商

        [StringLength(100)]
        public string Model { get; set; } = string.Empty; // 型号

        [StringLength(20)]
        public string Status { get; set; } = "正常"; // 状态：正常、维修中、报废

        public DateTime? LastMaintenanceDate { get; set; } // 上次维护日期

        public DateTime? NextMaintenanceDate { get; set; } // 下次维护日期

        [StringLength(500)]
        public string MaintenanceRecord { get; set; } = string.Empty; // 维护记录

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
    }
}