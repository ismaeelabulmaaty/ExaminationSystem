using Core.Models;
using ExaminationSystem.Dtos.ChoiceDto;

namespace ExaminationSystem.Dtos.QuestionDto
{
    public class QuestionToReturnDto
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public int Grade { get; set; }
        public ICollection<ChoicesDto> Choices { get; set; } = new List<ChoicesDto>();
    }
}
