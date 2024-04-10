using System.Text.Json.Serialization;

namespace NasaInfo.Models
{
    public class Oggetto_Sistema
    {
        [JsonIgnore]
        public Sistema sis { get; set; } = null!;
        public OggettoCeleste ogg { get; set; } = null!;

        [JsonIgnore]
        public int SistemaRif { get; set; }
        public int OggettoRif { get; set; }
    }
}
