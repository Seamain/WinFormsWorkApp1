using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 健康记录模型
    /// </summary>
    [Table("HealthRecords")]
    public class HealthRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }

        [Required]
        public DateTime RecordDate { get; set; }

        [StringLength(20)]
        public string RecordType { get; set; } = string.Empty; // 体检、日常监测、疾病记录

        // 生命体征
        public decimal? BloodPressureHigh { get; set; } // 收缩压
        public decimal? BloodPressureLow { get; set; } // 舒张压
        public decimal? HeartRate { get; set; } // 心率
        public decimal? Temperature { get; set; } // 体温
        public decimal? BloodSugar { get; set; } // 血糖
        public decimal? Weight { get; set; } // 体重
        public decimal? Height { get; set; } // 身高

        [StringLength(1000)]
        public string Symptoms { get; set; } = string.Empty; // 症状描述

        [StringLength(1000)]
        public string Diagnosis { get; set; } = string.Empty; // 诊断结果

        [StringLength(1000)]
        public string Treatment { get; set; } = string.Empty; // 治疗方案

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        [Required]
        [StringLength(50)]
        public string RecorderName { get; set; } = string.Empty; // 记录人员

        [StringLength(20)]
        public string RecorderType { get; set; } = string.Empty; // 护理人员、医疗人员

        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}