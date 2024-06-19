using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OyunHaberSitesi.Model;
namespace OyunHaberSitesi.Model
{
    public class WeatherAndRatesViewModel
    {
        public WeatherResponse Weather { get; set; }
        public ExchangeRateResponse ExchangeRates { get; set; }
    }
}