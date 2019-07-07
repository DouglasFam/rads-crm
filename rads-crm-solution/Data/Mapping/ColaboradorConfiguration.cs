using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class ColaboradorConfiguration : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
        
                builder.ToTable("colaborador", "pma");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Adm)
                    .HasColumnName("adm")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                builder.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                builder.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                builder.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                builder.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");
          
            throw new NotImplementedException();
        }
    }
}
