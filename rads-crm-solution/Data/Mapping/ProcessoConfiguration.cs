using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class ProcessoConfiguration : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
          
                builder.ToTable("processo", "pma");

                builder.HasIndex(e => e.IdAdverso)
                    .HasName("idAdverso");

                builder.HasIndex(e => e.IdCliente)
                    .HasName("idCliente");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.IdAdverso)
                    .HasColumnName("idAdverso")
                    .HasColumnType("int(11)");

                builder.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .HasColumnType("int(11)");
           
        }
    }
}
