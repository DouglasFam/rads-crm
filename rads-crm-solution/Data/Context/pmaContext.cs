using System;
using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Data.Context
{
    public partial class pmaContext : DbContext
    {
        public pmaContext()
        {
        }

        public pmaContext(DbContextOptions<pmaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adverso> Adverso { get; set; }
        public virtual DbSet<Agendamento> Agendamento { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Colaborador> Colaborador { get; set; }
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<Controle> Controle { get; set; }
        public virtual DbSet<Processo> Processo { get; set; }
        public virtual DbSet<Ramo> Ramo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=127.0.0.1;port=3306;user=root;database=pma");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.ApplyConfiguration(new AdversoConfiguration());
            modelBuilder.ApplyConfiguration(new AgendamentoConfiguration());

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("cliente", "pma");

                entity.HasIndex(e => e.Idcolcad)
                    .HasName("fk_colcad");

                entity.HasIndex(e => e.Indicacao)
                    .HasName("indicacao");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Datacadastro).HasColumnName("datacadastro");

                entity.Property(e => e.Datafinalempresa)
                    .HasColumnName("datafinalempresa")
                    .HasColumnType("date");

                entity.Property(e => e.Datainiempresa)
                    .HasColumnName("datainiempresa")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ender)
                    .HasColumnName("ender")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idcolcad)
                    .HasColumnName("idcolcad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Indicacao)
                    .HasColumnName("indicacao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Colaborador>(entity =>
            {
                entity.ToTable("colaborador", "pma");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Adm)
                    .HasColumnName("adm")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<Contato>(entity =>
            {
                entity.ToTable("contato", "pma");

                entity.HasIndex(e => e.Idcliente)
                    .HasName("idcliente");

                entity.HasIndex(e => e.Idcolaborador)
                    .HasName("idcolaborador");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Datacontato)
                    .HasColumnName("datacontato")
                    .HasColumnType("date");

                entity.Property(e => e.Idcliente)
                    .HasColumnName("idcliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idcolaborador)
                    .HasColumnName("idcolaborador")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Obs)
                    .HasColumnName("obs")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Controle>(entity =>
            {
                entity.ToTable("controle", "pma");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Datalimite).HasColumnName("datalimite");
            });

            modelBuilder.Entity<Processo>(entity =>
            {
                entity.ToTable("processo", "pma");

                entity.HasIndex(e => e.IdAdverso)
                    .HasName("idAdverso");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("idCliente");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdAdverso)
                    .HasColumnName("idAdverso")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Ramo>(entity =>
            {
                entity.ToTable("ramo", "pma");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });
        }
    }
}
