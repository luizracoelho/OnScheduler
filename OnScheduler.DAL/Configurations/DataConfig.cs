using System.Data.Entity.ModelConfiguration;

namespace OnScheduler.DAL.Configurations
{
    public class DataConfig : EntityTypeConfiguration<Data>
    {
        public DataConfig()
        {
            ToTable("Datas");

            HasRequired(d => d.AgendamentoDiario)
                .WithMany(a => a.Datas)
                .HasForeignKey(x => x.AgendamentoDiario_Id);
        }
    }
}
