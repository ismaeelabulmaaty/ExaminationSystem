using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class StudentCourse : BaseModel
    {
        public int CoursesId { get; set; }
        public Course Courses { get; set; }
        public int StudentsId { get; set; }
        public Students Students { get; set; }
    }
}
