using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class AdversoConfiguration : IEntityTypeConfiguration<Adverso>
    {
        public void Configure(EntityTypeBuilder<Adverso> builder)
        {
                builder.ToTable("adverso", "pma");

                builder.HasIndex(e => e.IdRamo)
                    .HasName("id_Ramo");

                builder.HasIndex(e => e.Idcolcad)
                    .HasName("idcolcad");

                builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                builder.Property(e => e.IdRamo)
                    .HasColumnName("id_Ramo")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Idcolcad)
                    .HasColumnName("idcolcad")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                builder.HasOne(d => d.IdRamoNavigation)
                    .WithMany(p => p.Adverso)
                    .HasForeignKey(d => d.IdRamo)
                    .HasConstraintName("adverso_ibfk_1");

                builder.HasOne(d => d.IdcolcadNavigation)
                    .WithMany(p => p.Adverso)
                    .HasForeignKey(d => d.Idcolcad)
                    .HasConstraintName("adverso_ibfk_2");

        }
    }
}
