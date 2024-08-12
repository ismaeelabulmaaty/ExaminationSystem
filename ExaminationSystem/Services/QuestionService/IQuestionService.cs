
using ExaminationSystem.Dtos.QuestionDto;



namespace ExaminationSystem.Services.QuestionService

{
    public interface IQuestionService
    {
        int Add(QuestionsDto Model);
        IEnumerable<QuestionsDto> GetAll();
        QuestionsDto GetByID(int id);
        int UpdateQuestions(int id, QuestionsDto ViewModel);
        int DeleteQuestions(int id);
    }
}
