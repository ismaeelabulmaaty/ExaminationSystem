using Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Dtos.ExamQuestions
{
    public class ExamQuestionDto
    {
        public int ExamId { get; set; }
        public int QuestionId { get; set; }

    }
}
