
using ExaminationSystem.Dtos.Exam;
using ExaminationSystem.Helper;
using ExaminationSystem.Models;
using ExaminationSystem.Services.ExamService;
using ExaminationSystem.Services.Question;
using ExaminationSystem.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamServices _examService;

        public ExamController(IExamServices examService)
        {
            _examService = examService;
        }
        [HttpGet]
        public ResultViewModel<IEnumerable<ExamDto>> GetAllExams()
        {
            var Data = _examService.GetAll().Select(x => x.MapOne<ExamDto>());
            return new ResultViewModel<IEnumerable<ExamDto>>
            {
                IsSuccess = true,
                Data = Data,

            };

        }

        [HttpGet("{id}")]
        public ResultViewModel<ExamDto> GetByID(int id)
        {
            var exam = _examService.GetByID(id);
            var examViewModel = exam.MapOne<ExamDto>();
            return new SuccessResultViewModel<ExamDto>(examViewModel, "");
        }

        [HttpPut("UpdateExam")]
        public ResultViewModel<int> Update ( int id, ExamDto examVreatViewModel)
        {
          var Data =   _examService.UpdateExam(id, examVreatViewModel);
            return new ResultViewModel<int>
            {
                IsSuccess = true,
                Data = Data,   
            };
        }

        [HttpPost("CreatExam")]
        public ResultViewModel<int> Creat(ExamDto viewModel)
        {
            var exam = viewModel.MapOne<ExamToReturnDto>();
           
            var Data =_examService.Add(exam);
             return new ResultViewModel<int>
            {
                IsSuccess = true,
                Data = Data,
            };
        }

        [HttpDelete("DeleteExam")]
        public bool Delete(int id)
        {
            _examService.DeleteExam(id);
            return true;
        }

    }
}
