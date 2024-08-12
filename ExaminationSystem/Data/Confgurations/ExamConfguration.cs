using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Confgurations
{
    public class ExamConfguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasOne (e => e.Instructor)
                   .WithMany (i=>i.Exams)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Course)
                   .WithMany();

            builder.HasMany(e => e.ExamQuestions)
                   .WithOne(i => i.Exam);



            builder.Property(E => E.StartDate)
                   .IsRequired();
        }
    }
}
