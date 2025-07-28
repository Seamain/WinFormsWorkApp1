using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 请假记录模型
    /// </summary>
    [Table("LeaveRecords")]
    public class LeaveRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        [Required]
        [StringLength(20)]
        public string LeaveType { get; set; } = string.Empty; // 请假类型：事假、病假、年假、婚假、产假等

        [Required]
        public DateTime StartDate { get; set; } // 开始日期

        [Required]
        public DateTime EndDate { get; set; } // 结束日期

        public decimal Days { get; set; } // 请假天数

        [StringLength(500)]
        public string Reason { get; set; } = string.Empty; // 请假原因

        [StringLength(20)]
        public string Status { get; set; } = "待审批"; // 状态：待审批、已批准、已拒绝

        [StringLength(50)]
        public string ApprovedBy { get; set; } = string.Empty; // 审批人

        public DateTime? ApprovalDate { get; set; } // 审批日期

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        public DateTime CreateTime { get; set; } // 创建时间
    }
}