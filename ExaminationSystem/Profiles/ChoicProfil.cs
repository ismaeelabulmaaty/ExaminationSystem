using AutoMapper;
using Core.Models;
using ExaminationSystem.Dtos.ChoiceDto;

namespace ExaminationSystem.Profiles
{
    public class ChoicProfil : Profile
    {
        public ChoicProfil()
        {
            CreateMap<Choices , ChoicesDto>().ReverseMap();
        }
    }
}
