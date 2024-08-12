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
    public class QuestionConfguration : IEntityTypeConfiguration<Questions>
    {
        public void Configure(EntityTypeBuilder<Questions> builder)
        {
            builder.Property(Q => Q.Text) 
                   .IsRequired();
        }
    }
}
