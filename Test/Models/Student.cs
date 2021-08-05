using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string RollNumber { get; set;}
        public string StudentName { get; set; }
        public DateTime StudentDOB { get; set; }
        public string Email { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}