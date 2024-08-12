using AutoMapper;
using Core.Repository.Conttract;
using ExaminationSystem.Dtos.QuestionDto;
using ExaminationSystem.Helper;
using ExaminationSystem.Services.Exams;
using ExaminationSystem.Models;
using Core.Models;
using ExaminationSystem.Services;


namespace ExaminationSystem.Services.QuestionService
{
    public class QuestionServices : IQuestionService
    {
        private readonly IGenericRepository<Questions> _genericRepository;
        private readonly IMapper _mapper;

        public QuestionServices(IGenericRepository<Questions> genericRepository,
            IMapper mapper )

        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        
        }
        public IEnumerable<QuestionsDto> GetAll()
        {
            var Questions = _genericRepository.GetAll();

            return Questions.Map<QuestionsDto>();

        }

        public QuestionsDto GetByID(int id)
        {
            var Question = _genericRepository.GetByID(id);
            var mapped = _mapper.Map<Questions, QuestionsDto>(Question);

            return mapped;
        }
        public int Add(QuestionsDto QuestionDto)
        {


            var Question = _genericRepository.Add(new Questions
            {
                Text = QuestionDto.Text,
                Grade = QuestionDto.Grade,

            });


            _genericRepository.SaveChanges();
            return Question.Id;
        }

        public int UpdateQuestions(int id, QuestionsDto QuestionDto)
        {

            var Question = _genericRepository.GetByID(id);

            Question.Text = QuestionDto.Text;
            Question.Id = id;
            Question.Grade = QuestionDto.Grade;

            _genericRepository.Update(Question);
            _genericRepository.SaveChanges();
            return Question.Id;

        }

        public int DeleteQuestions(int id)
        {
            var Question = _genericRepository.GetByID(id);
            _genericRepository.Delete(Question);
            _genericRepository.SaveChanges();
            return Question.Id;

        }




    }
}
