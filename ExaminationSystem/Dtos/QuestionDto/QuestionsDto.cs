using Core.Models;
using ExaminationSystem.Dtos.ChoiceDto;
using ExaminationSystem.Models;
using System.Collections.ObjectModel;

namespace ExaminationSystem.Dtos.QuestionDto
{
    public class QuestionsDto
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public int Grade { get; set; }
        public List<int> Choices { get; set; } = new List<int>();
    }
}
