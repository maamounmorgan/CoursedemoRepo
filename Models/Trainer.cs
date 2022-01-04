using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseDemo.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Passowrd { get; set; }
        public string Website { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}