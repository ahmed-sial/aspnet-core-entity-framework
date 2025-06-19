using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCorePractice.Models
{
    public class StudentModel
    {
        [Key]
        [Column("s_id")]
        public int Id { get; set; }
        [Column("full_name", TypeName = "VARCHAR(100)")]
        public string Name { get; set; }
        [Column("c_gpa", TypeName = "DECIMAL(3, 2)")]
        public double Cgpa { get; set; }
    }
}
