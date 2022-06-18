using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WeatherWebService.ViewModels;

namespace WeatherWebService
{
    /// <summary>
    /// Summary description for WeatherWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WeatherWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public WeatherDetailsVM GetWeather(string City)
        {
            return Weather.GetWeatherDetails(City);
        }
    }
}
