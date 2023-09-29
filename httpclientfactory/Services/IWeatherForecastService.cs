namespace apiconsume.Services
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetAllWeathers();
    }
}
