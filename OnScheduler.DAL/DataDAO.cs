using OnBase;
using OnScheduler.DAL.Context;

namespace OnScheduler.DAL
{
    public class DataDAO : BaseDataAccess<Data>
    {
        public DataDAO() : base(new DataContext())
        {

        }
    }
}
