using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Confgurations
{
    public class CoursesConfguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            //builder.HasOne(e => e.Instructors)
            //    .WithMany(c=>c.Courses)
            //    .HasForeignKey(e => e.InstructorsId);

            //builder.HasMany(e => e.Exams)
            //    .WithOne(e => e.Course)
            //    .OnDelete(DeleteBehavior.NoAction);





            builder.Property(C => C.Name)
                   .IsRequired();

            builder.Property(C => C.StartDate)
                   .IsRequired();

            builder.Property(C => C.EndDate)
                   .IsRequired();

            builder.Property(C => C.CreditHours)
                   .IsRequired();

        }
    }
}
