using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class ControleConfiguration : IEntityTypeConfiguration<Controle>
    {
        public void Configure(EntityTypeBuilder<Controle> builder)
        {
          
                builder.ToTable("controle", "pma");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Datalimite).HasColumnName("datalimite");
          

            throw new NotImplementedException();
        }
    }
}
