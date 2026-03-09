using System;
using System.Collections.Generic;
using System.Text;

namespace EFPorject2.Models
{
    internal class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public ICollection<Homework> Homeworks { get; set; } = new List<Homework>();
    }
}
