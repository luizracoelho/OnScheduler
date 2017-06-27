using OnBase;
using OnScheduler.DAL.Context;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace OnScheduler.DAL
{
    public class AgendamentoDiarioDAO : BaseDataAccess<AgendamentoDiario>
    {
        public AgendamentoDiarioDAO() : base(new DataContext())
        {

        }

        public override AgendamentoDiario Get(int id)
        {
            using (var ctx = new DataContext())
            {
                return ctx.AgendamentosDiarios.Include(x => x.Datas).FirstOrDefault(x => x.Id == id);
            }
        }

        public override List<AgendamentoDiario> List()
        {
            using (var ctx = new DataContext())
            {
                return ctx.AgendamentosDiarios.Include(x => x.Datas).ToList();
            }
        }
    }
}

