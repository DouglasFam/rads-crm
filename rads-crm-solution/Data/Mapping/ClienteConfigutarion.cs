using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class ClienteConfigutarion : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
          
                builder.ToTable("cliente", "pma");

                builder.HasIndex(e => e.Idcolcad)
                    .HasName("fk_colcad");

                builder.HasIndex(e => e.Indicacao)
                    .HasName("indicacao");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                builder.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.Datacadastro).HasColumnName("datacadastro");

                builder.Property(e => e.Datafinalempresa)
                    .HasColumnName("datafinalempresa")
                    .HasColumnType("date");

                builder.Property(e => e.Datainiempresa)
                    .HasColumnName("datainiempresa")
                    .HasColumnType("date");

                builder.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.Ender)
                    .HasColumnName("ender")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(e => e.Idcolcad)
                    .HasColumnName("idcolcad")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Indicacao)
                    .HasColumnName("indicacao")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(15)
                    .IsUnicode(false);
         



            throw new NotImplementedException();
        }
    }
}
