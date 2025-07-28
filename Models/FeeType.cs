using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 费用类型模型
    /// </summary>
    [Table("FeeTypes")]
    public class FeeType
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string TypeName { get; set; } = string.Empty; // 费用类型名称：床位费、护理费、餐费等
        
        [StringLength(200)]
        public string Description { get; set; } = string.Empty; // 费用描述
        
        [Required]
        public decimal StandardPrice { get; set; } // 标准价格
        
        [StringLength(20)]
        public string BillingCycle { get; set; } = "月"; // 计费周期：日、月、年
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreateTime { get; set; } = DateTime.Now;
        
        // 导航属性
        public virtual ICollection<FeeRecord> FeeRecords { get; set; } = new List<FeeRecord>();
    }
}