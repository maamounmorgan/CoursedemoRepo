using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseDemo.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}