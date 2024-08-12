using Core.Models;
using ExaminationSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Dtos.Exam
{
    public class ExamDto 
    {
        public int ExamId { get; set; }
        public DateTime StartDate { get; set; }
        public int TotalGrade { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public ICollection<int> QuestionsIDs { get; set; }

    }
}
