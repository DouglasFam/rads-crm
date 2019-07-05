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
        public virtual DbSet<Controle> Controle { get; set; }
        public virtual DbSet<Ramo> Ramo { get; set; }

        // Unable to generate entity type for table 'pma.contato'. Please see the warning messages.
        // Unable to generate entity type for table 'pma.processo'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #region warning
                //To protect potentially sensitive information in your connection string,
                //you should move it out of source code.See http://go.microsoft.com/fwlink/?LinkId=723263 
                //for guidance on storing connection strings.
                #endregion 
                optionsBuilder.UseMySQL("Server=127.0.0.1;port=3306;user=root;database=pma");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Adverso>(entity =>
            {
                entity.ToTable("adverso", "pma");

                entity.HasIndex(e => e.IdRamo)
                    .HasName("id_Ramo");

                entity.HasIndex(e => e.Idcolcad)
                    .HasName("idcolcad");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdRamo)
                    .HasColumnName("id_Ramo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idcolcad)
                    .HasColumnName("idcolcad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRamoNavigation)
                    .WithMany(p => p.Adverso)
                    .HasForeignKey(d => d.IdRamo)
                    .HasConstraintName("adverso_ibfk_1");

                entity.HasOne(d => d.IdcolcadNavigation)
                    .WithMany(p => p.Adverso)
                    .HasForeignKey(d => d.Idcolcad)
                    .HasConstraintName("adverso_ibfk_2");
            });

            modelBuilder.Entity<Agendamento>(entity =>
            {
                entity.ToTable("agendamento", "pma");

                entity.HasIndex(e => e.Idcliente)
                    .HasName("idcliente");

                entity.HasIndex(e => e.Idcolcad)
                    .HasName("idcolcad");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Idcliente)
                    .HasColumnName("idcliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idcolcad)
                    .HasColumnName("idcolcad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(11)");
            });

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

            modelBuilder.Entity<Controle>(entity =>
            {
                entity.ToTable("controle", "pma");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Datalimite).HasColumnName("datalimite");
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
