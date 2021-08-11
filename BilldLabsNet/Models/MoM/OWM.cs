using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilldLabsNet.Models.MoM
{

    public class OpenWeatherMaps
    {
        public string cod { get; set; }
        public float message { get; set; }
        public int cnt { get; set; }
        public List[] list { get; set; }
        public City city { get; set; }
    }

    public class City
    {
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
    }

    public class Coord
    {
        public decimal lat { get; set; }
        public decimal lon { get; set; }
    }

    public class List
    {
        public int dt { get; set; }
        public Main main { get; set; }
        public Weather[] weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Sys sys { get; set; }
        public DateTime dt_txt { get; set; }
    }

    public class Main
    {
        public decimal temp { get; set; }
        public decimal temp_min { get; set; }
        public decimal temp_max { get; set; }
        public decimal pressure { get; set; }
        public decimal sea_level { get; set; }
        public decimal grnd_level { get; set; }
        public decimal humidity { get; set; }
        public decimal temp_kf { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Wind
    {
        public decimal speed { get; set; }
        public decimal deg { get; set; }
    }

    public class Rain
    {
        public float _3h { get; set; }
    }

    public class Sys
    {
        public string pod { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

}