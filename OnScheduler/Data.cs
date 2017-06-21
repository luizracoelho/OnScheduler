using OnBase;
using System;

namespace OnScheduler
{
    public class Data : Base
    {
        public DayOfWeek DiaSemana { get; set; }

        public TimeSpan Hora { get; set; }

        public AgendamentoDiario AgendamentoDiario { get; set; }

        public int AgendamentoDiario_Id { get; set; }
    }
}

