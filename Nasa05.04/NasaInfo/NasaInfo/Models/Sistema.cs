namespace NasaInfo.Models
{
    public class Sistema
    {
        public int SistemaId { get; set; }
        public string? Codice { get; set; } = null;
        public string? Nome { get; set; } = null;
        public string? Tipo { get; set; } = null;

        public IEnumerable<Oggetto_Sistema> ElencoOggSis { get; set; } = new List<Oggetto_Sistema>();
    }
}
