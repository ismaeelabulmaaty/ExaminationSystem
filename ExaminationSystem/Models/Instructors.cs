using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Instructors : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Exam> Exams { get; set; } = new HashSet<Exam>();
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
