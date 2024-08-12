
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using ExaminationSystem.AutoFac;
using ExaminationSystem.Helper;
using ExaminationSystem.Profiles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ExaminationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}); //dependancy injection ...dbcontext 


builder.Host.UseServiceProviderFactory( new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
    builder.RegisterModule(new AutoFacModule()));

builder.Services.AddAutoMapper(typeof(ExamProfil));
builder.Services.AddAutoMapper(typeof(CourceProfile));
builder.Services.AddAutoMapper(typeof(QuestionProfil));
builder.Services.AddAutoMapper(typeof(ChoicProfil));

var app = builder.Build();

MapperHelper.Mapper = app.Services.GetService<IMapper>();
#region UpdateDataBase

using
var Scope = app.Services.CreateScope();
var Service = Scope.ServiceProvider;
var LoggerFactory = Service.GetService<ILoggerFactory>();
try
{
    var DbContext = Service.GetRequiredService<ExaminationDbContext>();
    await DbContext.Database.MigrateAsync(); //update database
                                             //Scope.Dispose();
}
catch (Exception ex)
{

    var Logger = LoggerFactory.CreateLogger<Program>();
    Logger.LogError(ex, "An Error Occurde During Appling The Migration");
}

#endregion
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
