using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseDemo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}