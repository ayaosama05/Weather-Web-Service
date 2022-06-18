using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WeatherWebService.ViewModels;

namespace WeatherWebService
{
    public partial class UserInterface : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                WeatherDetailsVM Weather_Details = Weather.GetWeatherDetails(City_Text.Text);
                CountryLBL.Text = Weather_Details.Country;
                RegionLBL.Text = Weather_Details.Region;
                TimeLBL.Text = Weather_Details.Current_time.ToString();
                StatusLBL.Text = Weather_Details.Weather_Status;
                TempLBL.Text = Weather_Details.temperature.ToString();
            }
            catch (Exception ex)
            {
                ErrorLBL.Text = ex.Message;
            }
        }
    }
}