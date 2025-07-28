using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 用药记录模型
    /// </summary>
    [Table("MedicationRecords")]
    public class MedicationRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }

        [Required]
        public int MedicationId { get; set; }
        public virtual Medication Medication { get; set; }

        [Required]
        public DateTime StartDate { get; set; } // 开始用药日期

        public DateTime? EndDate { get; set; } // 结束用药日期

        [Required]
        [StringLength(100)]
        public string Dosage { get; set; } = string.Empty; // 剂量

        [Required]
        [StringLength(100)]
        public string Frequency { get; set; } = string.Empty; // 用药频率

        [StringLength(100)]
        public string Usage { get; set; } = string.Empty; // 用法

        [StringLength(500)]
        public string Purpose { get; set; } = string.Empty; // 用药目的

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        [Required]
        [StringLength(50)]
        public string PrescribedBy { get; set; } = string.Empty; // 开药医生

        [StringLength(20)]
        public string Status { get; set; } = "进行中"; // 进行中、已停药、已完成

        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}