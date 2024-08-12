using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Course : BaseModel
    {
        public string Name { get; set; }
        public int CreditHours { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("Instructors")]
        public int InstructorsId { get; set; }
        public Instructors Instructors { get; set; }
        public ICollection<Exam> Exams { get; set; } = new HashSet<Exam>();

    }
}
