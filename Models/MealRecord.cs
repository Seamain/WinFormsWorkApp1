using System.ComponentModel.DataAnnotations;

namespace WinFormsWorkApp1.Models
{
    public class MealRecord
    {
        public int Id { get; set; }
        
        [Required]
        public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }
        
        [Required]
        public DateTime MealDate { get; set; }
        
        [Required]
        [StringLength(20)]
        public string MealType { get; set; } = string.Empty; // 早餐、午餐、晚餐、加餐
        
        [StringLength(500)]
        public string MenuItems { get; set; } = string.Empty;
        
        [StringLength(20)]
        public string Appetite { get; set; } = string.Empty; // 良好、一般、较差
        
        [StringLength(500)]
        public string SpecialDiet { get; set; } = string.Empty; // 特殊饮食要求
        
        [StringLength(500)]
        public string Notes { get; set; } = string.Empty;
        
        public DateTime CreateTime { get; set; } = DateTime.Now;
        
        [StringLength(50)]
        public string CreatedBy { get; set; } = string.Empty;
    }
}