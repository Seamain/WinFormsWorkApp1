using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 缴费记录模型
    /// </summary>
    [Table("PaymentRecords")]
    public class PaymentRecord
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int FeeRecordId { get; set; } // 费用记录ID
        
        [Required]
        public decimal PaymentAmount { get; set; } // 缴费金额
        
        [Required]
        public DateTime PaymentDate { get; set; } // 缴费日期
        
        [Required]
        [StringLength(20)]
        public string PaymentMethod { get; set; } = string.Empty; // 缴费方式：现金、银行卡、支付宝、微信等
        
        [StringLength(50)]
        public string ReceiptNumber { get; set; } = string.Empty; // 收据号
        
        [StringLength(50)]
        public string Operator { get; set; } = string.Empty; // 操作员
        
        [StringLength(500)]
        public string Remarks { get; set; } = string.Empty; // 备注
        
        public DateTime CreateTime { get; set; } = DateTime.Now;
        
        // 导航属性
        public virtual FeeRecord FeeRecord { get; set; } = null!;
    }
}