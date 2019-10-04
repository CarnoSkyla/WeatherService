using System;
using System.Threading.Tasks;
using WeatherServiceLibrary.Models;
using WeatherServiceLibrary;

namespace WeatherService
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var displayWeather = await CTWeatherWebService.GetWeather();
            Console.WriteLine("The Weather Report for Cape Town is");
            Console.WriteLine(displayWeather.Temperature.ToString());


            Console.WriteLine(displayWeather.Humidity.ToString());
            Console.WriteLine(displayWeather.Weather);
        }
    }
}
