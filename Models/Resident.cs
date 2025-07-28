using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 老人信息模型
    /// </summary>
    [Table("Residents")]
    public class Resident
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty; // 姓名

        [StringLength(20)]
        public string IdCard { get; set; } = string.Empty; // 身份证号

        [StringLength(10)]
        public string Gender { get; set; } = string.Empty; // 性别

        public DateTime? BirthDate { get; set; } // 出生日期

        public int Age { get; set; } // 年龄

        [StringLength(20)]
        public string Phone { get; set; } = string.Empty; // 联系电话

        [StringLength(200)]
        public string Address { get; set; } = string.Empty; // 家庭住址

        [StringLength(50)]
        public string EmergencyContact { get; set; } = string.Empty; // 紧急联系人

        [StringLength(20)]
        public string EmergencyPhone { get; set; } = string.Empty; // 紧急联系电话

        [StringLength(500)]
        public string MedicalHistory { get; set; } = string.Empty; // 病史

        [StringLength(500)]
        public string Allergies { get; set; } = string.Empty; // 过敏史

        [StringLength(20)]
        public string Status { get; set; } = "待入住"; // 状态：待入住、已入住、已退住

        public int? BedId { get; set; } // 床位ID

        public DateTime? CheckInDate { get; set; } // 入住日期

        public DateTime? CheckOutDate { get; set; } // 退住日期

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        public DateTime CreateTime { get; set; } = DateTime.Now; // 创建时间

        public DateTime? UpdateTime { get; set; } // 更新时间

        // 导航属性
        public virtual Bed? Bed { get; set; }
    }
}