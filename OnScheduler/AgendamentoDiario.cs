﻿using System;
using System.Collections.Generic;

namespace OnScheduler
{
    public class AgendamentoDiario : Agendamento
    {
        public List<Data> Datas { get; set; }

        public DateTime? DataUltimaExecucao { get; set; }
    }
}
