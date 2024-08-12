

using ExaminationSystem.Dtos.ExamQuestions;

namespace ExaminationSystem.Services.Exams
{
    public interface IExamQuestionService
    {
        void Add(ExamQuestionDto viewModel);
        void AddRange(int examId, IEnumerable<int> QIds);
    }
}
 
