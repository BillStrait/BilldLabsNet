using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Caching;
using System.Xml.Serialization;
using BilldLabsNet.Models.MoM;
using Newtonsoft.Json;

namespace BilldLabsNet.Helpers
{
    public class MomHelper
    {
        private static decimal GetMarsTemp()
        {
            var tempMarsTemp = (decimal?)HttpRuntime.Cache["Mars"];
            if (tempMarsTemp == null)
            {
                var client = new WebClient();
                var marsData = new weather_report();
                //Get Mars data
                var marsResponse = client.OpenRead(new Uri("http://cab.inta-csic.es/rems/rems_weather.xml"));
                if (marsResponse != null)
                {
                    var marsReader = new StreamReader(marsResponse);
                    var xmlSerializer = new XmlSerializer(typeof(weather_report));
                    marsData = (weather_report)xmlSerializer.Deserialize(marsReader);
                    tempMarsTemp = (decimal)((marsData.magnitudes.max_temp * 9m) / 5m) + 32m;
                }

            }
            return tempMarsTemp.Value;
        }

        private static decimal GetMinneapolisTemp()
        {
            var tempMspTemp = (decimal?)HttpRuntime.Cache["MSP"];

            if (tempMspTemp == null)
            {
                //Data isn't in cache, get Minneapolis data
                var client = new WebClient();
                var owmKey = ConfigurationManager.AppSettings["OpenWeatherMapsKey"];
                var targetUrl = $"https://api.openweathermap.org/data/2.5/forecast?zip=55435&APPID={owmKey}&units=imperial";
                var mspData = new OpenWeatherMaps();
                var mspResponse = client.OpenRead(new Uri(targetUrl));
                var mspReader = new StreamReader(mspResponse);
                var mspString = mspReader.ReadToEnd();
                mspData = (OpenWeatherMaps)JsonConvert.DeserializeObject<OpenWeatherMaps>(mspString, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DateFormatHandling = DateFormatHandling.MicrosoftDateFormat });
                //this api helpfully returns in UTC. Since I'm in central it's not a big help. Doing DateTime.Today.UTC() didn't work so great. 
                var items = mspData.list.Any(c => c.dt_txt.AddHours(-5).Day == DateTime.Today.Day)
                    ? mspData.list.Where(c => c.dt_txt.AddHours(-5).Day == DateTime.Today.Day).ToList()
                    : mspData.list.ToList();

                tempMspTemp = items.Max(c => c.main.temp_max);
                client.Dispose();



                //This block is all for Weather Underground, and they're killing their API. Needs to be replaced.
                //var mspData = new Models.MoM.Msp.Rootobject();
                //var mspResponse = client.OpenRead(new Uri("http://api.wunderground.com/api/0df2b1eba4f0c0ae/forecast/q/MN/Minneapolis.json"));


                HttpRuntime.Cache.Insert("MSP", tempMspTemp, null, DateTime.Today.AddDays(1), Cache.NoSlidingExpiration);
            }

            return (decimal)tempMspTemp;
        }

        public MOMVM GetVm()
        {
            var mars = GetMarsTemp();
            var msp = GetMinneapolisTemp();
            var vm = new MOMVM
            {
                MarsHigh = mars,
                MSPHigh = msp,
                ColdestPlace = msp > mars ? "Mars" : "Minneapolis"
            };
            return vm;
        }
    }
}