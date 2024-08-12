using AutoMapper;
using Core.Models;
using Core.Repository.Conttract;
using ExaminationSystem.Dtos.Exam;
using ExaminationSystem.Exceptions;
using ExaminationSystem.Helper;
using ExaminationSystem.Models;
using ExaminationSystem.Services.Exams;
using ExaminationSystem.Services.Question;



namespace ExaminationSystem.Services.ExamService
{
    public class ExamServices : IExamServices
    {
        private readonly IGenericRepository<Exam> _genericRepository;
        private readonly IMapper _mapper;
        private readonly IExamQuestionService _examQuestionService;
        private readonly IGenericRepository<Questions> _questionRepo;

        public ExamServices(IGenericRepository<Exam> genericRepository,
            IMapper mapper ,IExamQuestionService examQuestionService,
            IGenericRepository<Questions> QuestionRepo)

        {
            _genericRepository = genericRepository;
            _mapper = mapper;
            _examQuestionService = examQuestionService;
            _questionRepo = QuestionRepo;
        }
        public IEnumerable<ExamDto> GetAll()
        {
            var exams = _genericRepository.GetAll();

            return exams.Map<ExamDto>();

        }

        public ExamDto GetByID(int id)
        {
            var exam = _genericRepository.GetByID(id);
           var mapped =_mapper.Map<ExamDto>(exam);

            return mapped;
        }
        public int Add(ExamToReturnDto examDto)
        {

            var Questions = _questionRepo.GetAll();
            var TotalGrade = Questions.Sum(x => x.Grade);
            var exam = _genericRepository.Add(new Exam
            {
                StartDate = examDto.StartDate,
                CourseId = examDto.CourseId,
                InstructorId = examDto.InstructorId,
                TotalGrade = TotalGrade

            }) ;


            _examQuestionService.AddRange(exam.Id, examDto.QuestionsId);
            _genericRepository.SaveChanges();
            return exam.Id;
        }

        public int UpdateExam( int id , ExamDto examDto)
        {

            var exam = _genericRepository.GetByID(id);
            
            exam.TotalGrade = examDto.TotalGrade;
            exam.StartDate = examDto.StartDate;
            exam.CourseId = examDto.CourseId;
            exam.InstructorId = examDto.InstructorId;
            

            _genericRepository.Update(exam);
            _genericRepository.SaveChanges();
            return exam.Id;

        }

        public int DeleteExam(int id)
        {
            var exam = _genericRepository.GetByID(id);
            _genericRepository.Delete(exam);
            _genericRepository.SaveChanges();
            return exam.Id;

        }

       
    }
}
