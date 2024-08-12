using Core.Models;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace Repository.Data
{
    public class ExaminationDbContext : DbContext
    {
        public ExaminationDbContext(DbContextOptions<ExaminationDbContext> options) : base(options)
        {
           // ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Choices> Choices { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        public DbSet<Students> Students { get; set; }
    }
}
