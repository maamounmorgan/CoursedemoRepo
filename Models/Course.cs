using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseDemo.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int TrainerId { get; set; }
        public virtual Trainer Trainer { get; set; }


        public virtual ICollection<CourseLesson> CourseLessons { get; set; }

        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}