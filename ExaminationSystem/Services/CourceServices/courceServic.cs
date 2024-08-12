using AutoMapper;
using Core.Models;
using Core.Repository.Conttract;
using ExaminationSystem.Dtos.CourceDtos;
using ExaminationSystem.Dtos.Exam;
using ExaminationSystem.Helper;
using ExaminationSystem.Models;

namespace ExaminationSystem.Services.CourceServices
{
    public class courceServic : ICourceService
    {
        private readonly IGenericRepository<Course> _genericRepository;
        private readonly IMapper _mapper;

        public courceServic(IGenericRepository<Course> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public IEnumerable<CourceDto> GetAll()
        {
            var Cource = _genericRepository.GetAll();
            return Cource.Map<CourceDto>();
        }
        public CourceDto GetByID(int id)
        {
            var Cource = _genericRepository.GetByID(id);
            return Cource.MapOne<CourceDto>();
        }
        public int UpdateCource(int id, CourceDto courseDto)
        {
            var Cource = _genericRepository.GetByID(id);
            Cource.Name = courseDto.Name;
            Cource.Description = courseDto.Description;
            Cource.StartDate = courseDto.StartDate;
            Cource.EndDate = courseDto.EndDate;
            Cource.CreditHours = courseDto.CreditHours;

            _genericRepository.Update(Cource);
            _genericRepository.SaveChanges();
            return Cource.Id;
        }
        public int Add(CourceDto courceDto)
        {
            var Cource = _genericRepository.Add(new Course
            {
                StartDate = courceDto.StartDate,
                EndDate = courceDto.EndDate,
                Name = courceDto.Name,
                Description = courceDto.Description,
                CreditHours = courceDto.CreditHours,
                InstructorsId = courceDto.InstructorsId,


            });

            _genericRepository.SaveChanges();
            return Cource.Id;
        }
        public int DeleteCource(int id)
        {
            var Cource = _genericRepository.GetByID(id);
            _genericRepository.Delete(Cource);
            _genericRepository.SaveChanges();
            return Cource.Id;

        }

    }
}
