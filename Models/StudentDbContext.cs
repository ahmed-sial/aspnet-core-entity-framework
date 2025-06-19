using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCorePractice.Models
{
    public class StudentDbContext : DbContext
    {
        public DbSet<StudentModel> Student { get; set; }
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
