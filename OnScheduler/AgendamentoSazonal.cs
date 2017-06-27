namespace OnScheduler
{
    public class AgendamentoSazonal : Agendamento
    {
        public TipoSazonalidade TipoSazonalidade { get; set; }

        public decimal TempoAviso { get; set; }

        public string Sazonalidade {
            get {
                return $"{TempoAviso.ToString("N0")} {TipoSazonalidade}";
            }
        }
    }

    public enum TipoSazonalidade
    {
        Minutos,
        Horas,
        Dias
    }
}
