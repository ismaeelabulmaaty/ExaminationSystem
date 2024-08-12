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
    public class StudentsConfguration : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            builder.Property(S => S.FirstName)
                   .IsRequired()
                   .HasMaxLength(100); ;
            builder.Property(S => S.LastName)
                   .IsRequired()
                   .HasMaxLength(100); ;
            
                   
        }
    }
}
