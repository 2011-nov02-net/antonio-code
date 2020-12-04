using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Schedule { get; set; }
    }
}
