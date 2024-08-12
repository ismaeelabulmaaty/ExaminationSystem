
using Core.Models;
using ExaminationSystem.Dtos.CourceDtos;
using ExaminationSystem.Dtos.Exam;
using ExaminationSystem.Helper;
using ExaminationSystem.Models;
using ExaminationSystem.Services.CourceServices;
using ExaminationSystem.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourceController : ControllerBase
    {
        private readonly ICourceService _courceService;

        public CourceController(ICourceService courceService)
        {
            _courceService = courceService;
        }
        [HttpGet]
        public ResultViewModel<IEnumerable<CourceDto>> GetAllCources()
        {
            var Cources = _courceService.GetAll()
                                        .Select(x => x.MapOne<CourceDto>());
            return new ResultViewModel<IEnumerable<CourceDto>>
            {
                IsSuccess = true,
                Data = Cources
            };

        }

        [HttpGet("{id}")]
        public ResultViewModel<CourceDto> GetCourceById(int id)
        {
            var Cources = _courceService.GetByID(id);
            var CourceViewModel = Cources.MapOne<CourceDto>();
            return new SuccessResultViewModel<CourceDto>(CourceViewModel, "");
        }
        [HttpPut]
        public ResultViewModel<int> Update(int id, CourceDto courceDto)
        {
            var Data = _courceService.UpdateCource(id, courceDto);
            return new ResultViewModel<int>
            {
                IsSuccess = true,
                Data = Data,

            };
        }

        [HttpPost("CreatCource")]
        public ResultViewModel<int> Creat(Course Model)
        {
            var Cource = Model.MapOne<CourceDto>();
            var Data = _courceService.Add(Cource);
            return new ResultViewModel<int>
            {
                IsSuccess = true,
                Data = Data,
            };
        }

        [HttpDelete("Delete")]
        public bool Delete(int id)
        {
            _courceService.DeleteCource(id);
            return true;
        }

    }
}
