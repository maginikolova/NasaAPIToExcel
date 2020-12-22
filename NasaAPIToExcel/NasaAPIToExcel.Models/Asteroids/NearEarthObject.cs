using NasaAPIToExcel.Models.Asteroids.CloseApproach;
using NasaAPIToExcel.Models.Asteroids.EstimatedDiameterData;
using Newtonsoft.Json;
using System;

namespace NasaAPIToExcel.Models.Asteroids
{
    public class NearEarthObject
    {
        [JsonProperty("id")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("neo_reference_id")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long NeoReferenceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public Uri NasaJplUrl { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public double AbsoluteMagnitudeH { get; set; }

        [JsonProperty("estimated_diameter")]
        public EstimatedDiameter someth{ get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsPotentiallyHazardousAsteroid { get; set; }

        [JsonProperty("close_approach_data")]
        public CloseApproachData[] CloseApproachData { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool IsSentryObject { get; set; }
    }
}
