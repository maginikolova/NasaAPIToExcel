using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NasaAPIToExcel.Models.Asteroids
{
    public class AsteroidsApiData
    {
        public DateTime Date { get; set; }

        [JsonProperty("element_count")]
        public long ElementCount { get; set; }

        [JsonProperty("near_earth_objects")]
        public Dictionary<string, NearEarthObject[]> NearEarthObjects { get; set; }
    }
}
