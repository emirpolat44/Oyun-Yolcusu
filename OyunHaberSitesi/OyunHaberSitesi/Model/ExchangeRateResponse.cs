using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OyunHaberSitesi.Model
{
    public class ExchangeRateResponse
    {
        public Rates Rates { get; set; }
    }

    public class Rates
    {
        public double USD { get; set; }
        public double EUR { get; set; }
        public double CHF { get; set; }
        public double TRY { get; set; }
    }
}