using AutoMapper;
using Core.Models;
using ExaminationSystem.Dtos.CourceDtos;

namespace ExaminationSystem.Profiles
{
    public class CourceProfile : Profile
    {

        public CourceProfile()
        {
            CreateMap<Course, CourceDto>().ForMember(dst => dst.CourceId, opt => opt.MapFrom(src => src.Id)).ReverseMap();
        }
    }
}
