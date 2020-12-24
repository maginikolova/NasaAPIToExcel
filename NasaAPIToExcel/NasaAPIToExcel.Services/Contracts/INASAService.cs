using NasaAPIToExcel.Models.APOD;
using NasaAPIToExcel.Models.Asteroids;
using System;
using System.Threading.Tasks;

namespace NasaAPIToExcel.Services.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface INASAService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public Task<AstronomyPictureOfTheDay> GetAPODDataAsync(DateTime dateTime);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public Task<AsteroidsApiData> GetAsteroidsFeedDataAsync(DateTime dateTime);
    }
}
