using Microsoft.Extensions.Configuration;
using NasaAPIToExcel.Models.Asteroids;
using NasaAPIToExcel.Services.Contracts;
using System;

namespace NasaAPIToExcel.Services
{
    public class AsteroidsService : IAsteroidsService
    {
        private const string NasaAsteroidsUrl = "https://api.nasa.gov/neo/rest/v1/feed?start_date={0}&end_date={0}&api_key={1}";
        private const string NasaAPODUrl = "https://api.nasa.gov/planetary/apod?api_key={0}";
        private readonly string apiKey;

        public AsteroidsService(IConfiguration config)
        {
            this.apiKey = config.GetSection("APIKeys").GetSection("NASA").Value;
        }

        public AsteroidsApiData GetBasicAsteroidData(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
