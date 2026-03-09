using System;
using System.Collections.Generic;
using System.Text;

namespace EFPorject2.Models
{
    internal class Homework
    {
        public int HomeworkId { get; set; }

        public string Content { get; set; }

        public DateTime SubmissionTime { get; set; }
        public ContentType ContentType { get; set; }
        public int StudentId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
        

    }
}
