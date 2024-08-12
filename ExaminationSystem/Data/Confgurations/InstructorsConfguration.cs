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
    public class InstructorsConfguration : IEntityTypeConfiguration<Instructors>
    {
        public void Configure(EntityTypeBuilder<Instructors> builder)
        {

            builder.Property(I => I.FirstName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(I => I.LastName)
                   .IsRequired()
                    .HasMaxLength(50);


        }
    }
}
