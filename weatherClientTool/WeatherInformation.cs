using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherClientTool
{
    public class WeatherInformation
    {
        public async Task<weatherModel> GetWeatherInfo(double latitude, double longitude)
        {
            weatherModel wethModel = null;
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.open-meteo.com");
                    var response = await client.GetAsync($"/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true");

                    if (response.IsSuccessStatusCode)
                    {
                        wethModel = await response.Content.ReadAsAsync<weatherModel>();
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }
            return wethModel;
        }

        public async Task RunAsync(GeoInfo geoInfoValue)
        {
            try
            {
                double latitude = geoInfoValue.latitude;
                double longitude = geoInfoValue.longitude;
                weatherModel weather_model = null;
                weather_model = await GetWeatherInfo(latitude, longitude);
                ShowWeatherInformation(weather_model);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ShowWeatherInformation(weatherModel weather_model)
        {
            Console.WriteLine($"Temparature: {weather_model.current_Weather.temperature}");
            Console.WriteLine($"WindSpeed: {weather_model.current_Weather.windSpeed}\n");
        }
    }
}
