namespace OnScheduler
{
    public class AgendamentoSazonal : Agendamento
    {
        public TipoSazonalidade TipoSazonalidade { get; set; }

        public decimal TempoAviso { get; set; }
    }

    public enum TipoSazonalidade
    {
        Minutos,
        Horas,
        Dias
    }
}
