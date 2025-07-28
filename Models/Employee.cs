using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsWorkApp1.Models
{
    /// <summary>
    /// 员工信息模型
    /// </summary>
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty; // 员工姓名

        [Required]
        [StringLength(18)]
        public string IdCard { get; set; } = string.Empty; // 身份证号

        [StringLength(50)]
        public string Username { get; set; } = string.Empty; // 用户名

        [StringLength(255)]
        public string Password { get; set; } = string.Empty; // 密码（加密存储）

        [StringLength(10)]
        public string Gender { get; set; } = string.Empty; // 性别

        public DateTime? BirthDate { get; set; } // 出生日期

        public int? Age { get; set; } // 年龄

        [StringLength(20)]
        public string Phone { get; set; } = string.Empty; // 联系电话

        [StringLength(200)]
        public string Address { get; set; } = string.Empty; // 家庭住址

        [StringLength(50)]
        public string EmergencyContact { get; set; } = string.Empty; // 紧急联系人

        [StringLength(20)]
        public string EmergencyPhone { get; set; } = string.Empty; // 紧急联系人电话

        [Required]
        [StringLength(50)]
        public string Position { get; set; } = string.Empty; // 职位

        [StringLength(50)]
        public string Department { get; set; } = string.Empty; // 部门

        public DateTime HireDate { get; set; } // 入职日期

        public DateTime? TerminationDate { get; set; } // 离职日期

        [StringLength(20)]
        public string Status { get; set; } = "在职"; // 状态：在职、离职

        [StringLength(500)]
        public string Notes { get; set; } = string.Empty; // 备注

        public DateTime CreateTime { get; set; } // 创建时间

        public DateTime? UpdateTime { get; set; } // 更新时间
    }
}