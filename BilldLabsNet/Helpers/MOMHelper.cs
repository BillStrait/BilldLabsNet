using System;
using System.Collections.Generic;
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
    public class MOMHelper
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
                var marsReader = new StreamReader(marsResponse);

                var xmlSerializer = new XmlSerializer(typeof(weather_report));
                marsData = (weather_report)xmlSerializer.Deserialize(marsReader);
                tempMarsTemp = (decimal)((marsData.magnitudes.max_temp * 9m) / 5m) + 32m;
            }
            return tempMarsTemp.Value;
        }

        private static decimal GetMinneapolisTemp()
        {
            var tempMspTemp = (decimal?)HttpRuntime.Cache["MSP"];

            if (tempMspTemp == null)
            {
                var client = new WebClient();
                //Get Minneapolis Data
                var mspData = new Models.MoM.Msp.Rootobject();
                var mspResponse = client.OpenRead(new Uri("http://api.wunderground.com/api/0df2b1eba4f0c0ae/forecast/q/MN/Minneapolis.json"));
                var mspReader = new StreamReader(mspResponse);
                var mspString = mspReader.ReadToEnd();
                mspData = (Models.MoM.Msp.Rootobject)JsonConvert.DeserializeObject<Models.MoM.Msp.Rootobject>(mspString, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                decimal x;
                decimal.TryParse(mspData.forecast.simpleforecast.forecastday[0].high.fahrenheit, out x);
                tempMspTemp = x;
                client.Dispose();

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