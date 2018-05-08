using OnBase;
using System;

namespace OnScheduler
{
    public class Agendamento : Base
    {
        public string Url { get; set; }

        public string Descricao { get; set; }

        public DateTime? DataUltimaExecucao { get; set; }
    }
}