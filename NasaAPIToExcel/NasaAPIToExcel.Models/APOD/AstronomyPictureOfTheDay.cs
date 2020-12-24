﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NasaAPIToExcel.Models.APOD
{
    public partial class AstronomyPictureOfTheDay
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        [JsonProperty("hdurl")]
        public Uri Hdurl { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("service_version")]
        public string ServiceVersion { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
