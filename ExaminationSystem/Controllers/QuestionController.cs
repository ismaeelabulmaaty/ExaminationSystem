
using Core.Models;
using ExaminationSystem.Dtos.CourceDtos;
using ExaminationSystem.Dtos.Exam;
using ExaminationSystem.Dtos.QuestionDto;
using ExaminationSystem.Helper;
using ExaminationSystem.Models;
using ExaminationSystem.Services.CourceServices;
using ExaminationSystem.Services.ExamService;
using ExaminationSystem.Services.QuestionService;
using ExaminationSystem.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _QuestionService;

        public QuestionController(IQuestionService QuestionService)
        {
            _QuestionService = QuestionService;
        }
        [HttpGet]
        public ResultViewModel<IEnumerable<QuestionsDto>> GetAllQuestion()
        {
            var Questions = _QuestionService.GetAll()
                                            .Select(x => x.MapOne<QuestionsDto>());
            return new ResultViewModel<IEnumerable<QuestionsDto>>
            {
                IsSuccess = true,
                Data = Questions
            };

        }

        [HttpGet("{id}")]
        public ResultViewModel<QuestionsDto> GetQuestionById(int id)
        {
            var Questions = _QuestionService.GetByID(id);
            var QuestionsViewModel = Questions.MapOne<QuestionsDto>();
            return new SuccessResultViewModel<QuestionsDto>(QuestionsViewModel, "");
        }

        [HttpPut]
        public ResultViewModel<int> Update(int id, QuestionsDto QuestionsDto)
        {
            var Data = _QuestionService.UpdateQuestions(id, QuestionsDto);
            return new ResultViewModel<int>
            {
                IsSuccess = true,
                Data = Data,
            };
        }
        
        [HttpPost("CreatCource")]
        public ResultViewModel<int> Creat(QuestionToReturnDto Model)
        {
            var Questions = Model.MapOne<QuestionsDto>();
            var Data = _QuestionService.Add(Questions);
            return new ResultViewModel<int>
            {
                IsSuccess = true,
                Data = Data,
            };
        }

        
        [HttpDelete("Delete")]
        public bool Delete(int id)
        {
            _QuestionService.DeleteQuestions(id);
            return true;
        }

    }
}
