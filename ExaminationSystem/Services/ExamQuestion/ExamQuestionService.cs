
using Core.Repository.Conttract;
using ExaminationSystem.Dtos.ExamQuestions;
using ExaminationSystem.Models;


namespace ExaminationSystem.Services.Exams
{
    public class ExamQuestionService : IExamQuestionService
    {
        IGenericRepository<ExamQuestion> _repository;

        public ExamQuestionService(IGenericRepository<ExamQuestion> repository)
        {
            _repository = repository;
        }
        public void Add(ExamQuestionDto viewModel)
        {
            var exam = _repository.Add(new ExamQuestion
            {
                ExamId = viewModel.ExamId,
                QuestionId = viewModel.QuestionId,
            });

            _repository.SaveChanges();
        }

        

        public void AddRange(int examID, IEnumerable<int> QIDs)
        {
            foreach (int id in QIDs)
            {
                _repository.Add(new ExamQuestion
                {
                    ExamId = examID,
                    QuestionId = id,
                });
            }

            _repository.SaveChanges();
        }
    }
}
