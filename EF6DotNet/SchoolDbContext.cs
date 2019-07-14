using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EF6DotNet
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(string connectionString) : base(connectionString)
        {
            // Database initialization strategies.
            Database.SetInitializer(new SchoolDbInitializer());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
