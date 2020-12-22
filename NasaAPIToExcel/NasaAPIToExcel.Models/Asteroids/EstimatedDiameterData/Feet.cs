using Newtonsoft.Json;

namespace NasaAPIToExcel.Models.Asteroids.EstimatedDiameterData
{
    public class Feet
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }
}
