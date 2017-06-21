using System.Data.Entity.ModelConfiguration;

namespace OnScheduler.DAL.Configurations
{
    public class AgendamentoConfig : EntityTypeConfiguration<Agendamento>
    {
        public AgendamentoConfig()
        {
            ToTable("Agendamentos");
        }
    }
}
