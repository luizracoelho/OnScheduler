using OnBase;
using OnScheduler.DAL.Context;
using System;

namespace OnScheduler.DAL
{
    public class AgendamentoDAO : BaseDataAccess<Agendamento>
    {
        public AgendamentoDAO() : base(new DataContext())
        {

        }
    }
}
