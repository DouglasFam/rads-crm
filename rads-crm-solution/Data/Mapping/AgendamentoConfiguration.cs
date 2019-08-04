using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class AgendamentoConfiguration : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {

                builder.ToTable("agendamento", "pma");

                builder.HasIndex(e => e.Idcliente)
                    .HasName("idcliente");

                builder.HasIndex(e => e.Idcolcad)
                    .HasName("idcolcad");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Data).HasColumnName("data");

                builder.Property(e => e.Idcliente)
                    .HasColumnName("idcliente")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Idcolcad)
                    .HasColumnName("idcolcad")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(11)");
        }
    }
}
