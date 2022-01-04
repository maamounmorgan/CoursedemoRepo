using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseDemo.Models
{
    public class CourseLesson
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int OrderNumber { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}