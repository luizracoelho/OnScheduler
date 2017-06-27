using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnScheduler.DAL.Configurations
{
    public class AgendamentoSazonalConfig : EntityTypeConfiguration<AgendamentoSazonal>
    {
        public AgendamentoSazonalConfig()
        {
            Ignore(x => x.Sazonalidade);
        }
    }
}
