namespace core_api.Model
{
    public class Auditoria
    {
        public int Id { get; set; } = 0;
        public string usuario { get; set; } = string.Empty;
        public string acao { get; set; } = string.Empty;
        public string detalhes { get; set; } = string.Empty;
        public DateTime dataHora { get; set; }
        public Auditoria()
        {
            
        }
    }
}
