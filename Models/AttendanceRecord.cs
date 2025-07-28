using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 考勤记录模型
    /// </summary>
    [Table("AttendanceRecords")]
    public class AttendanceRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        [Required]
        public DateTime AttendanceDate { get; set; } // 考勤日期

        public DateTime? CheckInTime { get; set; } // 签到时间

        public DateTime? CheckOutTime { get; set; } // 签退时间

        [StringLength(20)]
        public string Status { get; set; } = string.Empty; // 状态：正常、迟到、早退、缺勤、请假

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        public DateTime CreateTime { get; set; } // 创建时间
    }
}