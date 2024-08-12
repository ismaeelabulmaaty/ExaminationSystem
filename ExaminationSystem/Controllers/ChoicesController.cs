using Core.Models;
using ExaminationSystem.Dtos.ChoiceDto;
using ExaminationSystem.Dtos.CourceDtos;
using ExaminationSystem.Helper;
using ExaminationSystem.Services.Choice;
using ExaminationSystem.Services.CourceServices;
using ExaminationSystem.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoicesController : ControllerBase
    {
        private readonly IChoiceServies _ChoiceService;

        public ChoicesController(IChoiceServies ChoiceService)
        {
            _ChoiceService = ChoiceService;
        }
        [HttpGet]
        public ResultViewModel<IEnumerable<ChoicesDto>> GetAllCources()
        {
            var Choice = _ChoiceService.GetAllChoice()
                                       .Select(x => x.MapOne<ChoicesDto>());
            return new ResultViewModel<IEnumerable<ChoicesDto>>
            {
                IsSuccess = true,
                Data = Choice

            };

        }

        [HttpGet("{id}")]
        public ResultViewModel<ChoicesDto> GetCourceById(int id)
        {
            var Choice = _ChoiceService.GetChoiceById(id);
            var ChoiceViewModel = Choice.MapOne<ChoicesDto>();
            return new SuccessResultViewModel<ChoicesDto>(ChoiceViewModel, "");
        }
        [HttpPut]
        public ResultViewModel<int> Update(int id, ChoicesDto ChoiceDto)
        {
            var Data = _ChoiceService.UpdateChoice(id, ChoiceDto);
            return new ResultViewModel<int>
            {
                IsSuccess = true,
                Data = Data,
            };
        }

        [HttpPost("CreatCource")]
        public ResultViewModel<int> Creat(ChoicesDto Model)
        {
            var Choice = Model.MapOne<ChoicesDto>();
            var Data = _ChoiceService.AddChoice(Choice);
            return new ResultViewModel<int>
            {
                IsSuccess = true,
                Data = Data,
            };
        }

        [HttpDelete("Delete")]
        public bool Delete(int id)
        {
            _ChoiceService.DeleteChoice(id);
            return true;
        }

    }
}
