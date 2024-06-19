using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OyunHaberSitesi.Model;

public class WeatherService
{
    private readonly HttpClient _httpClient = new HttpClient();
    private readonly string _apiKey = "c263d14fd8d4a833afe7fef395dd6ddb";
    private readonly string _baseUri = "http://api.openweathermap.org/data/2.5/weather";

    public async Task<WeatherResponse> GetWeatherAsync(string city)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{_baseUri}?q={city}&appid={_apiKey}&units=metric");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<WeatherResponse>();
        }
        catch (HttpRequestException ex)
        {
            throw new Exception($"Error getting weather data: {ex.Message}");
        }
    }
}