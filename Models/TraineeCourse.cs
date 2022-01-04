using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseDemo.Models
{
    public class TraineeCourse
    {
        public int Id { get; set; }
        public int Trainee_Id { get; set; }
        public int Course_Id { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}