using System;

namespace EF6DotNet
{
    public class StudentInfo
    {
        public int ID { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual Student Student { get; set; }
    }
}
