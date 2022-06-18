using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherWebService.ViewModels
{
    public class WeatherDetailsVM
    {
        public string Country { get; set; }
        public string Region { get; set; } 
        public string Current_time { get; set; }
        public string temperature { get; set; }
        public string Weather_Status { get;set; }
    }
}