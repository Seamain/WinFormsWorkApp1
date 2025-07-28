using System.ComponentModel.DataAnnotations;

namespace WinFormsWorkApp1.Models
{
    public class OutingRecord
    {
        public int Id { get; set; }
        
        [Required]
        public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Destination { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string Purpose { get; set; } = string.Empty;
        
        [Required]
        public DateTime OutTime { get; set; }
        
        public DateTime? ReturnTime { get; set; }
        
        [StringLength(100)]
        public string Companion { get; set; } = string.Empty;
        
        [StringLength(20)]
        public string CompanionPhone { get; set; } = string.Empty;
        
        [StringLength(20)]
        public string Status { get; set; } = "外出中"; // 外出中、已返回
        
        [StringLength(500)]
        public string Notes { get; set; } = string.Empty;
        
        public DateTime CreateTime { get; set; } = DateTime.Now;
        
        [StringLength(50)]
        public string CreatedBy { get; set; } = string.Empty;
    }
}