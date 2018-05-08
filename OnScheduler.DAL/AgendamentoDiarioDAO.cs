using OnBase;
using OnScheduler.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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

        public void EditUltimaExecucao(AgendamentoDiario agendamento)
        {
            try
            {
                using (var ctx = new DataContext())
                {
                    ctx.Agendamentos.Attach(agendamento);

                    ctx.Entry(agendamento).Property(x => x.DataUltimaExecucao).IsModified = true;

                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

