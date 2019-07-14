using System;
using System.Configuration;
using System.Linq;

namespace EF6DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SchoolContext"].ConnectionString;
            using (var ctx = new SchoolDbContext(connectionString))
            {
                var students = ctx.Students.ToList();
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.FirstMidName} erolled on {student.EnrollmentDate}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
