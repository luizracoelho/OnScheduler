using OnBase;
using OnScheduler.DAL;
using System;

namespace OnScheduler.BLL
{
    public class DataBO : BaseLogic<Data, DataDAO>
    {
        public DataBO()
        {

        }

        public override void Save(Data entity)
        {
            if(entity.DiaSemana == null || entity.Hora == null)
                throw new Exception("Todos os campos devem ser preenchidos.");

            base.Save(entity);
        }
    }
}
