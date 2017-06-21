using OnBase;
using OnScheduler.DAL;
using System;

namespace OnScheduler.BLL
{
    public class AgendamentoDiarioBO : BaseLogic<AgendamentoDiario, AgendamentoDiarioDAO>
    {
        public AgendamentoDiarioBO()
        {

        }

        public override void Save(AgendamentoDiario entity)
        {
            try
            {
                if (string.IsNullOrEmpty(entity.Url) || entity.Datas == null || string.IsNullOrEmpty(entity.Descricao))
                    throw new Exception("Todos os campos devem ser preenchidos.");

                //Fazer backup das datas
                var datas = entity.Datas;

                //Anular as datas
                entity.Datas = null;

                //Salvar o agendamento
                base.Save(entity);

                //Salvar as datas
                using (var dataBo = new DataBO())
                {
                    foreach (var data in datas)
                    {
                        data.AgendamentoDiario_Id = entity.Id;
                        dataBo.Save(data);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
