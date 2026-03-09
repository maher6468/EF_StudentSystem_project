using System;
using System.Collections.Generic;
using System.Text;

namespace EFPorject2.Models
{
    internal class Resource
    {
        public int ResourceId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public System.Security.AccessControl.ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
