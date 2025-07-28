using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 医疗监测模型
    /// </summary>
    [Table("MedicalMonitorings")]
    public class MedicalMonitoring
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }
        
        [Required]
        public DateTime MonitoringDate { get; set; }
        
        [Required]
        [StringLength(50)]
        public string MonitoringType { get; set; } = string.Empty; // 血压监测、血糖监测、心电监测等
        
        [StringLength(200)]
        public string MonitoringItem { get; set; } = string.Empty; // 具体监测项目
        
        [StringLength(100)]
        public string Result { get; set; } = string.Empty; // 监测结果
        
        [StringLength(50)]
        public string Unit { get; set; } = string.Empty; // 单位
        
        [StringLength(100)]
        public string NormalRange { get; set; } = string.Empty; // 正常范围
        
        [StringLength(20)]
        public string Status { get; set; } = string.Empty; // 正常、异常、需关注
        
        [StringLength(1000)]
        public string Recommendations { get; set; } = string.Empty; // 建议
        
        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注
        
        [Required]
        [StringLength(50)]
        public string MonitoredBy { get; set; } = string.Empty; // 监测人员
        
        [StringLength(20)]
        public string MonitoredByType { get; set; } = string.Empty; // 护理人员、医疗人员
        
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}