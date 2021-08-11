using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilldLabsNet.Models.MoM
{
    public class MOMVM
    {
        public string ColdestPlace { get; set; }
        public string Fact { get; set; }
        public string ImageUri { get; set; }
        public string ImageAltText { get; set; }
        public string ImageHeight { get; set; }
        public string ImageWidth { get; set; }
        public string ImageAttribution { get; set; }
        public decimal MarsHigh { get; set; }
        public decimal MSPHigh { get; set; }
    }
}