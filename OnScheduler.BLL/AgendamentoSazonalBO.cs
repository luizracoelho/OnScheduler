using OnBase;
using OnScheduler.DAL;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        public static async Task ExecutarAsync(AgendamentoSazonal agendamento)
        {
            TimeSpan? time = null;

            if (agendamento.TempoAviso >= 0)
            {
                if (agendamento.TipoSazonalidade == TipoSazonalidade.Dias)
                    time = TimeSpan.FromDays((double)agendamento.TempoAviso);
                else if (agendamento.TipoSazonalidade == TipoSazonalidade.Horas)
                    time = TimeSpan.FromHours((double)agendamento.TempoAviso);
                else
                    time = TimeSpan.FromMinutes((double)agendamento.TempoAviso);
            }

            using (var client = new HttpClient())
            {
                if (time != null)
                {
                    var rgxTime = new Regex(@"(\:)([a-zA-Z]{1,})");
                    agendamento.Url = rgxTime.Replace(agendamento.Url, time.Value.Ticks.ToString());
                }

                var rgx = new Regex("http://?");
                var preffix = rgx.IsMatch(agendamento.Url) ? "" : "http://";

                await client.GetAsync(preffix + agendamento.Url);
            }
        }
    }
}