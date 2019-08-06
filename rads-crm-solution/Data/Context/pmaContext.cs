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
                optionsBuilder.UseMySQL("Server=127.0.0.1;port=3306;user=root;database=pma;convert zero datetime=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.ApplyConfiguration(new AdversoConfiguration());
            modelBuilder.ApplyConfiguration(new AgendamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfigutarion());
            modelBuilder.ApplyConfiguration(new ColaboradorConfiguration());
            modelBuilder.ApplyConfiguration(new ContatoConfiguration());
            modelBuilder.ApplyConfiguration(new ControleConfiguration());
            modelBuilder.ApplyConfiguration(new ProcessoConfiguration());
            modelBuilder.ApplyConfiguration(new RamoConfiguration());
        }
    }
}
