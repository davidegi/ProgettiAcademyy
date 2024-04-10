namespace NasaInfo.Models
{
    public class OggettoCeleste
    {
        public int OggettoCelesteId { get; set; }
        public string? CodiceUnivoco { get; set; } = Guid.NewGuid().ToString();
        public string? Nome { get; set; } = null!;
        public DateTime DataScoperta { get; set; }
        public string? Scopritore { get; set; } = null!;
        public string? Tipologia { get; set; } = null!;
        public decimal? DistanzaTerra { get; set; } = null!;
        public decimal? CpRadiale { get; set; } = null!;
        public decimal? CpAngolare { get; set; } = null!;

        public IEnumerable<Oggetto_Sistema> ElencoOggSis { get; set; } = new List<Oggetto_Sistema>();
    }
}
