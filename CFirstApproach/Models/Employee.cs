using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFirstApproach.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }

        [Column("EmployeeName",TypeName ="varchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column("EmployeeGender", TypeName = "varchar(20)")]
        [Required]
        public string Gender { get; set; }

        [Required]
        public int? Age { get; set; }

        [Column("EmployeeCity", TypeName = "varchar(20)")]
        [Required]
        public string City { get; set; }

    }
}
