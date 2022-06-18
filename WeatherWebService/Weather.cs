using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Xml.Linq;
using WeatherWebService.ViewModels;

namespace WeatherWebService
{
    public class Weather
    {
        //to read the API key 
        private static string API_KEY = WebConfigurationManager.AppSettings["API_KEY"];

        public static XDocument CallURL(string city)
        {
            string URL = "https://api.weatherapi.com/v1/current.xml?key=" + API_KEY + "&q=" + city;

            XDocument X = XDocument.Load(URL);
            return X;
        }

        public static WeatherDetailsVM GetWeatherDetails(string city)
        {
            WeatherDetailsVM weatherDetailsVM = new WeatherDetailsVM();

            if (!CheckForSQLInjection(city) && !String.IsNullOrEmpty(city))
            {
                XDocument X = CallURL(city);
                weatherDetailsVM = new WeatherDetailsVM()
                {
                Country = X.Element("root").Element("location").Element("country").Value,
                Region = X.Element("root").Element("location").Element("region").Value,
                Current_time = X.Element("root").Element("location").Element("localtime").Value,
                temperature = X.Element("root").Element("current").Element("temp_c").Value,
                Weather_Status = X.Element("root").Element("current").Element("condition").Element("text").Value,
                };
            }

            return weatherDetailsVM;


        }
        //check SQL Injection
        public static Boolean CheckForSQLInjection(string userInput)
        {
            bool isSQLInjection = false;

            string[] sqlCheckList = { "--", ";--",";","/*","*/","@@","@","char","nchar","varchar","nvarchar",
                "execute","alter","begin","cast","create","cursor","declare","delete","drop","end","exec",
                "fetch", "insert","kill","select","sys","sysobjects","syscolumns","table","update"};

            string CheckString = userInput.Trim().Replace("'", "''");

            for (int i = 0; i <= sqlCheckList.Length - 1; i++)
            {
                if (CheckString.IndexOf(sqlCheckList[i],StringComparison.OrdinalIgnoreCase) >= 0)
                { isSQLInjection = true; }
            }

            return isSQLInjection;
        }
    }
}
