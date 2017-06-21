namespace OnScheduler.DAL.Context
{
    using OnScheduler.DAL.Configurations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AgendamentoConfig());
            modelBuilder.Configurations.Add(new DataConfig());
        }

        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<AgendamentoDiario> AgendamentosDiarios { get; set; }
        public DbSet<Data> Datas { get; set; }
    }

}