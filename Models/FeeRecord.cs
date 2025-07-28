using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 费用记录模型
    /// </summary>
    [Table("FeeRecords")]
    public class FeeRecord
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int ResidentId { get; set; } // 老人ID
        
        [Required]
        public int FeeTypeId { get; set; } // 费用类型ID
        
        [Required]
        public decimal Amount { get; set; } // 费用金额
        
        [Required]
        public DateTime BillingDate { get; set; } // 计费日期
        
        [Required]
        public DateTime DueDate { get; set; } // 到期日期
        
        [StringLength(20)]
        public string Status { get; set; } = "未缴费"; // 状态：未缴费、已缴费、逾期
        
        [StringLength(500)]
        public string Remarks { get; set; } = string.Empty; // 备注
        
        public DateTime CreateTime { get; set; } = DateTime.Now;
        
        // 导航属性
        public virtual Resident Resident { get; set; } = null!;
        public virtual FeeType FeeType { get; set; } = null!;
        public virtual ICollection<PaymentRecord> PaymentRecords { get; set; } = new List<PaymentRecord>();
    }
}