﻿using Newtonsoft.Json;
using System;

namespace NasaAPIToExcel.Models.Asteroids.CloseApproach
{
    public class CloseApproachData
    {
        [JsonProperty("close_approach_date")]
        public DateTime CloseApproachDate { get; set; }

        [JsonProperty("close_approach_date_full")]
        public string CloseApproachDateFull { get; set; }

        [JsonProperty("epoch_date_close_approach")]
        public long EpochDateCloseApproach { get; set; }

        [JsonProperty("relative_velocity")]
        public RelativeVelocity RelativeVelocity { get; set; }

        [JsonProperty("miss_distance")]
        public MissDistance MissDistance { get; set; }

        [JsonProperty("orbiting_body")]
        public string OrbitingBody { get; set; }
    }
}
