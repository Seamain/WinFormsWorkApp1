using System.ComponentModel.DataAnnotations;

namespace WinFormsWorkApp1.Models
{
    public class CareRecord
    {
        public int Id { get; set; }
        
        [Required]
        public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }
        
        public int? CarePackageId { get; set; }
        public virtual CarePackage? CarePackage { get; set; }
        
        [Required]
        public DateTime CareDate { get; set; }
        
        [Required]
        [StringLength(20)]
        public string CareType { get; set; } = string.Empty; // 日常护理、医疗护理、康复护理
        
        [StringLength(500)]
        public string CareContent { get; set; } = string.Empty;
        
        [StringLength(20)]
        public string CareResult { get; set; } = string.Empty; // 良好、一般、需要关注
        
        [StringLength(500)]
        public string Notes { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string CaregiverName { get; set; } = string.Empty;
        
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}