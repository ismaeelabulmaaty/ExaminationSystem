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
    public class ChoicesConfguration : IEntityTypeConfiguration<Choices>
    {
        public void Configure(EntityTypeBuilder<Choices> builder)
        {
            //builder.HasOne(c => c.Question)
            //       .WithMany(p => p.Choices)
            //       .HasForeignKey(c=>c.QuestionId)
            //      .OnDelete(DeleteBehavior.NoAction);

            

            builder.Property(c => c.Text)
                   .IsRequired();

        }
    }
}
