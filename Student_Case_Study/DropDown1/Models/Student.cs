using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDown1.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        public string Name { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}