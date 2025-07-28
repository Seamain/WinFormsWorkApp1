using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 仓库模型
    /// </summary>
    [Table("Warehouses")]
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty; // 仓库名称

        [StringLength(100)]
        public string Location { get; set; } = string.Empty; // 仓库位置

        [StringLength(50)]
        public string Manager { get; set; } = string.Empty; // 仓库管理员

        [StringLength(20)]
        public string ContactPhone { get; set; } = string.Empty; // 联系电话

        [StringLength(50)]
        public string Category { get; set; } = string.Empty; // 仓库类别：医疗用品仓、食品仓、生活用品仓等

        [StringLength(500)]
        public string Description { get; set; } = string.Empty; // 仓库描述

        public decimal Area { get; set; } // 仓库面积（平方米）

        public int Capacity { get; set; } // 仓库容量

        [StringLength(20)]
        public string Status { get; set; } = "正常使用"; // 状态：正常使用、维修中、关闭

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        // 导航属性
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();

        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
    }
}