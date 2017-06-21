using OnBase;
using OnScheduler.DAL.Context;

namespace OnScheduler.DAL
{
    public class AgendamentoDAO : BaseDataAccess<Agendamento>
    {
        public AgendamentoDAO() : base(new DataContext())
        {

        }
    }
}
