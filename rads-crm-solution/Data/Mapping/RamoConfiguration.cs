using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class RamoConfiguration : IEntityTypeConfiguration<Ramo>
    {
        public void Configure(EntityTypeBuilder<Ramo> builder)
        {
          
                builder.ToTable("ramo", "pma");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(60)
                    .IsUnicode(false);
         
        }
    }
}
