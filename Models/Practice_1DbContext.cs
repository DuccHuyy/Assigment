using Microsoft.EntityFrameworkCore;

namespace Practice_1.Models
{
    public class Practice_1DbContext : DbContext
    {
        public Practice_1DbContext(DbContextOptions<Practice_1DbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exams { get; set; }
    }
}
