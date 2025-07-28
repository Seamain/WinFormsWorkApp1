using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 床位信息模型
    /// </summary>
    [Table("Beds")]
    public class Bed
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string BedNumber { get; set; } = string.Empty; // 床位编号

        [Required]
        [StringLength(50)]
        public string RoomNumber { get; set; } = string.Empty; // 房间号

        [StringLength(20)]
        public string RoomType { get; set; } = string.Empty; // 房间类型：单人间、双人间、多人间

        [StringLength(20)]
        public string Status { get; set; } = "空闲"; // 空闲、已预定、已入住、维修中

        [Column(TypeName = "decimal(10,2)")]
        public decimal MonthlyRate { get; set; } // 月费用

        [StringLength(200)]
        public string Facilities { get; set; } = string.Empty; // 设施描述

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty;

        public DateTime CreateTime { get; set; } = DateTime.Now;

        public DateTime? UpdateTime { get; set; }

        // 导航属性
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}