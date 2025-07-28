using System.ComponentModel.DataAnnotations;

namespace WinFormsWorkApp1.Models
{
    public class CarePackage
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string PackageName { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        
        [StringLength(1000)]
        public string ServiceItems { get; set; } = string.Empty; // 服务项目列表
        
        [Required]
        public decimal MonthlyPrice { get; set; }
        
        [StringLength(20)]
        public string CareLevel { get; set; } = string.Empty; // 自理、半护理、全护理、特护
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreateTime { get; set; } = DateTime.Now;
        
        // 导航属性
        public virtual ICollection<CareRecord> CareRecords { get; set; } = new List<CareRecord>();
    }
}