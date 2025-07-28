using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 预定服务模型
    /// </summary>
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ConsultantId { get; set; }

        public int? BedId { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public DateTime PreferredMoveInDate { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = "待确认"; // 待确认、已确认、已取消、已入住

        [StringLength(100)]
        public string ServiceType { get; set; } = string.Empty; // 服务类型

        [Column(TypeName = "decimal(10,2)")]
        public decimal EstimatedCost { get; set; }

        [StringLength(500)]
        public string Requirements { get; set; } = string.Empty; // 特殊要求

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty;

        public DateTime CreateTime { get; set; } = DateTime.Now;

        public DateTime? UpdateTime { get; set; }

        // 导航属性
        [ForeignKey("ConsultantId")]
        public virtual Consultant Consultant { get; set; } = null!;

        [ForeignKey("BedId")]
        public virtual Bed? Bed { get; set; }
    }
}