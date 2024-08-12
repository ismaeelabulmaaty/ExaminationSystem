using Core.Models;
using ExaminationSystem.Dtos.ChoiceDto;
using ExaminationSystem.Dtos.QuestionDto;

namespace ExaminationSystem.Services.Choice
{
    public interface IChoiceServies
    {

        IEnumerable<ChoicesDto> GetAllChoice();
        ChoicesDto GetChoiceById(int id);

        int AddChoice(ChoicesDto ChoiceDto);
       
        int UpdateChoice(int id, ChoicesDto ChoiceDto);

        int DeleteChoice(int id);
    }  
}
