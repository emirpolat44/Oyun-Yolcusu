using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using OyunHaberSitesi.Model;
using System.Net.Http.Formatting;

namespace OyunHaberSitesi.Model
{
    public class ExchangeRateService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _apiKey = "17563723ab603ef860532043a627a9bb";
        private readonly string _baseUri = "http://api.exchangeratesapi.io/v1/latest";

        public async Task<ExchangeRateResponse> GetExchangeRatesAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{_baseUri}?access_key={_apiKey}&symbols=USD,EUR,CHF,TRY");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<ExchangeRateResponse>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error getting exchange rate data: {ex.Message}");
            }
        }
    }
}