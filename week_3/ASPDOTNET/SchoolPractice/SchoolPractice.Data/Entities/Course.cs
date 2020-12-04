using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public int? TeacherId { get; set; }
        public ICollection<Student> Roster { get; set; }
    }
}
