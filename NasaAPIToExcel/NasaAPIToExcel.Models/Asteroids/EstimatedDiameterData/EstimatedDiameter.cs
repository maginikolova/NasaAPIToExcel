using Newtonsoft.Json;

namespace NasaAPIToExcel.Models.Asteroids.EstimatedDiameterData
{
    public class EstimatedDiameter
    {
        [JsonProperty("kilometers")]
        public Feet Kilometers { get; set; }

        [JsonProperty("meters")]
        public Feet Meters { get; set; }

        [JsonProperty("miles")]
        public Feet Miles { get; set; }

        [JsonProperty("feet")]
        public Feet Feet { get; set; }
    }
}
