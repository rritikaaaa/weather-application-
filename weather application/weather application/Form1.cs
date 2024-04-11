using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using static System.Net.WebRequestMethods;

namespace weather_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKEY = "552a363c7f30e09de9d00ce78c39f87e";
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BTNSEARCH_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCITY.Text, APIKEY);
                var json = web.DownloadString(url);
                weatherinfo.root Info = JsonConvert.DeserializeObject<weatherinfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png" ;
                labcondition.Text = Info.weather[0].main;
                labdetail.Text = Info.weather[0].description;

                labsunrise.Text = convertDateTime( Info.sys.sunrise).ToString();
                labsunset.Text = convertDateTime(Info.sys.sunset).ToString();

                labwindspeed.Text=Info.wind.speed.ToString();
                labpressure.Text=Info.main.pressure.ToString();
            }
        }

        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime( 1970 , 1, 1, 0, 0, 0, 0,System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddMilliseconds(millisec).ToLocalTime();
            return day;
        }

        
    }
}
