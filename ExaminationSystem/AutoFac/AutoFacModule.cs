using Autofac;
using Core.Repository.Conttract;
using ExaminationSystem.Services.Choice;
using ExaminationSystem.Services.CourceServices;
using ExaminationSystem.Services.Exams;
using ExaminationSystem.Services.ExamService;
using ExaminationSystem.Services.QuestionService;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Data;
using Repository.ImplementRepository;

namespace ExaminationSystem.AutoFac
{
    public class AutoFacModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
         
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(ICourceService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IChoiceServies).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IQuestionService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IExamQuestionService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
