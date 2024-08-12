using Core.Models;
using ExaminationSystem.Dtos.Exam;
using ExaminationSystem.Dtos.QuestionDto;
using ExaminationSystem.Models;


namespace ExaminationSystem.Services.Question
{
    public interface IExamServices
    {
        int Add(ExamToReturnDto Model);
        IEnumerable<ExamDto> GetAll();
        ExamDto GetByID(int id);

        int UpdateExam(int id, ExamDto ViewModel);
        int DeleteExam(int id);
    }
}
