using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESchool.Models
{
    public class CourseTeacher
    {
        public long TeacherId { get; set; }
        public long CourseId { get; set; }
        public Course AssignedCourse { get; set; }
        public Course AssignedTeacher { get; set; }
    }
}
