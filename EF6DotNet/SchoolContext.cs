using System.Data.Entity;

namespace EF6DotNet
{
    public class SchoolContext: DbContext 
    {
        public SchoolContext(string connectionString): base(connectionString)
        {
            
        }
            
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
