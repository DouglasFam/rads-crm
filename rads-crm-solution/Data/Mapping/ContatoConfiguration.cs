using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class ContatoConfiguration : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
          
                builder.ToTable("contato", "pma");

                builder.HasIndex(e => e.Idcliente)
                    .HasName("idcliente");

                builder.HasIndex(e => e.Idcolaborador)
                    .HasName("idcolaborador");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Data).HasColumnName("data");

                builder.Property(e => e.Datacontato)
                    .HasColumnName("datacontato")
                    .HasColumnType("date");

                builder.Property(e => e.Idcliente)
                    .HasColumnName("idcliente")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Idcolaborador)
                    .HasColumnName("idcolaborador")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Obs)
                    .HasColumnName("obs")
                    .HasColumnType("mediumtext");

                builder.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");
       
        }
    }
}
