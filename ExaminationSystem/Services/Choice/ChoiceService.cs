using AutoMapper;
using Core.Models;
using Core.Repository.Conttract;
using ExaminationSystem.Dtos.ChoiceDto;
using ExaminationSystem.Dtos.QuestionDto;
using ExaminationSystem.Helper;


namespace ExaminationSystem.Services.Choice
{
    public class ChoiceService : IChoiceServies
    {

        private readonly IGenericRepository<Choices> _genericRepository;
        private readonly IMapper _mapper;

        public ChoiceService(IGenericRepository<Choices> genericRepository,
            IMapper mapper)

        {
            _genericRepository = genericRepository;
            _mapper = mapper;

        }
        public IEnumerable<ChoicesDto> GetAllChoice()
        {
            var Questions = _genericRepository.GetAll();

            return Questions.Map<ChoicesDto>();
        }
        public ChoicesDto GetChoiceById(int id)
        {
            var Question = _genericRepository.GetByID(id);
            var mapped = _mapper.Map<Choices, ChoicesDto>(Question);

            return mapped;
        }
        public int AddChoice(ChoicesDto ChoiceDto)
        {


            var Choice = _genericRepository.Add(new Choices
            {
                Text = ChoiceDto.Text,
                IsRightAnswer = ChoiceDto.IsRightAnswer,
                QuestionId = ChoiceDto.QuestionId,
               

            });


            _genericRepository.SaveChanges();
            return Choice.Id;
        }
        public int UpdateChoice(int id, ChoicesDto ChoiceDto)
        {

            var Choice = _genericRepository.GetByID(id);

            Choice.Text = ChoiceDto.Text;
            Choice.Id = ChoiceDto.ID;
            Choice.IsRightAnswer = ChoiceDto.IsRightAnswer;
            Choice.QuestionId = ChoiceDto.QuestionId;
            
            

            _genericRepository.Update(Choice);
            _genericRepository.SaveChanges();
            return ChoiceDto.ID;

        }
        public int DeleteChoice(int id)
        {
            var ChoiceDto = _genericRepository.GetByID(id);
            _genericRepository.Delete(ChoiceDto);
            _genericRepository.SaveChanges();
            return ChoiceDto.Id;

        }
    }
}
