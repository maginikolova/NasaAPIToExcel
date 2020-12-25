using Microsoft.Extensions.Configuration;
using NasaAPIToExcel.Models.APOD;
using NasaAPIToExcel.Models.Asteroids;
using NasaAPIToExcel.Services.Contracts;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NasaAPIToExcel.Services
{
    public class NASAService : INASAService
    {
        private const string NasaAPODUrl = "https://api.nasa.gov/planetary/apod?date={0}&api_key={1}";
        private const string NasaAsteroidsFeedUrl = "https://api.nasa.gov/neo/rest/v1/feed?start_date={0}&end_date={0}&api_key={1}";
        //private const string NasaAsteroidsLookupUrl = "https://api.nasa.gov/neo/rest/v1/neo/{0}?api_key={1}";
        //private const string NasaAsteroidsBrowseUrl = "http://www.neowsapp.com/rest/v1/neo/browse?page={0}&size={1}&api_key={2}";
        private readonly string apiKey;

        public NASAService(IConfiguration config)
        {
            this.apiKey = config.GetSection("APIKeys").GetSection("NASA").Value;
        }

        public async Task<AstronomyPictureOfTheDay> GetAPODDataAsync(DateTime dateTime)
        {
            var client = new HttpClient();

            var date = dateTime.ToString("yyyy-MM-dd");

            using (var response = await client.GetAsync(string.Format(NasaAPODUrl, date, apiKey)))
            {
                var responseAsString = await response.Content.ReadAsStringAsync();

                // TODO: FIX JSON/Feet bug
                return JsonConvert.DeserializeObject<AstronomyPictureOfTheDay>(responseAsString);
            }
        }

        public async Task<AsteroidsApiData> GetAsteroidsFeedDataAsync(DateTime dateTime)
        {
            var client = new HttpClient();

            var date = dateTime.ToString("yyyy-MM-dd");

            using (var response = await client.GetAsync(string.Format(NasaAsteroidsFeedUrl, date, apiKey)))
            {
                var responseAsString = await response.Content.ReadAsStringAsync();

                // TODO: FIX JSON/Feet bug
                return JsonConvert.DeserializeObject<AsteroidsApiData>(responseAsString);
            }
        }
    }
}
