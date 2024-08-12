using Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public class Exam : BaseModel
    {
        public DateTime StartDate { get; set; }
        public int TotalGrade { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }  
        public Instructors Instructor { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<ExamQuestion> ExamQuestions { get; set; }= new HashSet<ExamQuestion>();
    }
}
