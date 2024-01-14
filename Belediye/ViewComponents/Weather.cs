using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Belediye.ViewComponents
{
    public class Weather : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string api = "0928835605ea3e6b03f3a11f83b9d751";
            string city = "Bursa";
            string baseUrl = "https://api.openweathermap.org/data/2.5/weather";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{baseUrl}?q={city}&appid={api}");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(content);
                    double kelvinTemperature = json["main"]["temp"].Value<double>();
                    double celsiusTemperature = kelvinTemperature - 273.15;
                    string weatherDescription = json["weather"][0]["description"].Value<string>();
                    int humidity = json["main"]["humidity"].Value<int>();
                    double windSpeed = json["wind"]["speed"].Value<double>();
                    double rainProbability = json.SelectToken("rain.1h")?.Value<double>() ?? 0.0;
                    ViewBag.IconUrl = $"http://openweathermap.org/img/w/{json["weather"][0]["icon"].Value<string>()}.png";
                    ViewBag.Temperature = celsiusTemperature.ToString("0");
                    ViewBag.City = json["name"];
                    ViewBag.Description = weatherDescription;
                    ViewBag.Humidity = humidity;
                    ViewBag.WindSpeed = windSpeed;
                    ViewBag.RainProbability = rainProbability;
                }
            }
            return View();
        }
    }
}
