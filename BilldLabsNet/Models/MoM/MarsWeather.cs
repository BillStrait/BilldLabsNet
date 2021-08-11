using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilldLabsNet.Models.MoM.Mars
{
    public class Rootobject
    {
        public Report report { get; set; }
    }

    public class Report
    {
        public string terrestrial_date { get; set; }
        public int sol { get; set; }
        public decimal ls { get; set; }
        public decimal min_temp { get; set; }
        public decimal? min_temp_fahrenheit { get; set; }
        public decimal max_temp { get; set; }
        public decimal? max_temp_fahrenheit { get; set; }
        public decimal pressure { get; set; }
        public string pressure_string { get; set; }
        public object abs_humidity { get; set; }
        public object wind_speed { get; set; }
        public string wind_direction { get; set; }
        public string atmo_opacity { get; set; }
        public string season { get; set; }
        public DateTime sunrise { get; set; }
        public DateTime sunset { get; set; }
    }
}