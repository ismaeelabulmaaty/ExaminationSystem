using Core.Models;
using ExaminationSystem.Dtos.QuestionDto;

namespace ExaminationSystem.Dtos.Exam
{
    public class ExamToReturnDto
    {
        public int ExamId { get; set; }
        public DateTime StartDate { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public List<int> QuestionsId { get; set; }
    }
}
