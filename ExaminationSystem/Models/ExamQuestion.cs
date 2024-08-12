using Core.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    
    public class ExamQuestion : BaseModel
    {
        [ForeignKey("Exam")]
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public Questions Question { get; set; }
    }
}
