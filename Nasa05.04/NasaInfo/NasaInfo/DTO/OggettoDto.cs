namespace NasaInfo.DTO
{
    public class OggettoDto
    {

        // Eliminati dal DTO i seguenti campi: OggettoCelesteId, DataScoperta, ElencoOggSis
        public string? Cod { get; set; }
        public string? Nm { get; set; }
        public string? Scop { get; set; }
        public string? Tip { get; set; }
        public decimal? Dist { get; set; }
        public decimal? CpR{ get; set; }
        public decimal? CpA { get; set; }
    }
}
