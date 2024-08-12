using AutoMapper;
using Core.Models;
using ExaminationSystem.Dtos.Exam;
using ExaminationSystem.Dtos.QuestionDto;
using ExaminationSystem.Models;

namespace ExaminationSystem.Profiles
{
    public class QuestionProfil : Profile
    {

        public QuestionProfil()
        {
            CreateMap<Questions, QuestionsDto>().ForMember(ds => ds.Choices, op => op.MapFrom(src => src.Choices))
                                                .ForMember(ds => ds.QuestionId, op => op.MapFrom(src => src.Id))
                                                .ReverseMap();
            CreateMap<QuestionsDto, QuestionToReturnDto>()
                                                .ForMember(ds => ds.Choices, op => op.MapFrom(src => src.Choices))
                                                .ForMember(ds => ds.QuestionId, op => op.MapFrom(src => src.Choices))
                                                .ReverseMap();

            CreateMap<Choices, int>();



        }
    }
}
