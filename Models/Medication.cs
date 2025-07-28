using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 药物信息模型
    /// </summary>
    [Table("Medications")]
    public class Medication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string MedicationName { get; set; } = string.Empty; // 药物名称

        [StringLength(50)]
        public string MedicationType { get; set; } = string.Empty; // 药物类型

        [StringLength(200)]
        public string Specification { get; set; } = string.Empty; // 规格

        [StringLength(50)]
        public string Manufacturer { get; set; } = string.Empty; // 生产厂家

        [StringLength(1000)]
        public string Indications { get; set; } = string.Empty; // 适应症

        [StringLength(1000)]
        public string SideEffects { get; set; } = string.Empty; // 副作用

        [StringLength(500)]
        public string StorageConditions { get; set; } = string.Empty; // 储存条件

        public bool IsActive { get; set; } = true;

        public DateTime CreateTime { get; set; } = DateTime.Now;

        // 导航属性
        public virtual ICollection<MedicationRecord> MedicationRecords { get; set; } = new List<MedicationRecord>();
    }
}