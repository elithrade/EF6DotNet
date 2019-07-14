using System.Data.Entity;

namespace EF6DotNet
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(string connectionString) : base(connectionString)
        {
            // Database initialization strategies.

            // As the name suggests, this initializer drops an existing database
            // every time you run the application, irrespective of whether your
            // model classes have changed or not. This will be useful when you
            // want a fresh database every time you run the application, for
            // example when you are developing the application.
            Database.SetInitializer(new DropCreateDatabaseAlways<SchoolContext>());
            // This is the default initializer. As the name suggests, it will
            // create the database if none exists as per the configuration.
            // However, if you change the model class and then run the application with this initializer, then it will throw an exception. 
            Database.SetInitializer(new CreateDatabaseIfNotExists<SchoolContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure the default schema.

            // A database schema is a way to logically group objects such as tables, views, stored procedures etc. 
            // You can assign a user login permissions to a single schema so that the user
            // can only access the objects they are authorized to access.
            modelBuilder.HasDefaultSchema("Admin");

            // Mapping entity to table.
            modelBuilder.Entity<Student>().ToTable("Students");
            // Using dbo scheme.
            modelBuilder.Entity<Grade>().ToTable("Grades");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
