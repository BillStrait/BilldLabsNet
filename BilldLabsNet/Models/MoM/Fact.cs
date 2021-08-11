using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilldLabsNet.Models.MoM
{
    public class Fact
    {
        public int Id { get; set; }
        public string Planet { get; set; }
        public string Text { get; set; }
        public string ImageUri { get; set; }
        public string ImageAltText { get; set; }
        public int ImageHeight { get; set; }
        public int ImageWidth { get; set; }
        public string ImageAttribution { get; set; }
    }
}