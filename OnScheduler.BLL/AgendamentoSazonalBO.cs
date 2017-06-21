using OnBase;
using OnScheduler.DAL;
using System;

namespace OnScheduler.BLL
{
    public class AgendamentoSazonalBO : BaseLogic<AgendamentoSazonal, AgendamentoSazonalDAO>
    {
        public AgendamentoSazonalBO()
        {

        }

        public override void Save(AgendamentoSazonal entity)
        {
            if (entity.TempoAviso <= 0 || entity.TipoSazonalidade == null || string.IsNullOrEmpty(entity.Url) || string.IsNullOrEmpty(entity.Descricao))
                throw new Exception("Todos os campos devem ser preenchidos corretamente.");

            base.Save(entity);
        }
    }
}
