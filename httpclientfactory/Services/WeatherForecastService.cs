using apiconsume.Extensions;
using System.Text.Json;

namespace apiconsume.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {

        private readonly IHttpClientFactory _client;

        public WeatherForecastService(IHttpClientFactory client)
        {
            _client = client;
        }

        public async Task<IEnumerable<WeatherForecast>> GetAllWeathers()
        {
            var clientRequest = _client.CreateClient("Weatherapi");
            var response = await clientRequest.GetAsync("WeatherForecast");
            return await response.ReadContentAs<List<WeatherForecast>>();
        }
    }
}
