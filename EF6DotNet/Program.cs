using System.Configuration;

namespace EF6DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SchoolContext"].ConnectionString;
            using (var ctx = new SchoolContext(connectionString))
            {
                var bill = new Student() { StudentName = "Bill" };
        
                ctx.Students.Add(bill);
                ctx.SaveChanges();                
            }
        }
    }
}
