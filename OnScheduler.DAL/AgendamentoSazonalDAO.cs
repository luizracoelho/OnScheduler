using OnBase;
using OnScheduler.DAL.Context;

namespace OnScheduler.DAL
{
    public class AgendamentoSazonalDAO : BaseDataAccess<AgendamentoSazonal>
    {
        public AgendamentoSazonalDAO() : base(new DataContext())
        {
                
        }
    }
}
