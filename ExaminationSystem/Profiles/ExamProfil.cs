using AutoMapper;
using ExaminationSystem.Dtos.Exam;
using ExaminationSystem.Models;
using System.Security.Cryptography;

namespace ExaminationSystem.Profiles
{
    public class ExamProfil : Profile
    {
        public ExamProfil()
        {

            CreateMap<Exam, ExamDto>()
                      .ForMember(dst => dst.ExamId, opt => opt.MapFrom(src => src.Id));

            CreateMap<Exam, int>();

            CreateMap<Exam, ExamToReturnDto>()
                      .ForMember(d => d.QuestionsId, opt => opt.MapFrom(s => s.ExamQuestions.Select(eq => eq.Question)));

            CreateMap<ExamDto, ExamToReturnDto>().ReverseMap();
        }


    }
}
