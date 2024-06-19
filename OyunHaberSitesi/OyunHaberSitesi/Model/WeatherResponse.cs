using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OyunHaberSitesi.Model;

namespace OyunHaberSitesi.Model
{
    public class WeatherResponse
    {
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
    }

}