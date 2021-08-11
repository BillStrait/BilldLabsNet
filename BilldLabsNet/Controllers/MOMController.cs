using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Xml.Serialization;
using BilldLabsNet.Helpers;
using BilldLabsNet.Models;
using Newtonsoft.Json;
using BilldLabsNet.Models.MoM;

namespace BilldLabsNet.Controllers
{
    public class MOMController : Controller
    {
        // GET: MOM
        public ActionResult Index()
        {
            var helper = new MomHelper();
            var vm = helper.GetVm();



            //var context = new ChatContext();

            //var max = context.Facts.Count(c => c.Planet == vm.ColdestPlace);
            //var rand = new Random();
            //var fact = context.Facts.Where(c => c.Planet == vm.ColdestPlace).OrderBy(c => c.Id).Skip(rand.Next(max)).First();

            //vm.Fact = fact.Text;
            //vm.ImageAltText = fact.ImageAltText;
            //vm.ImageAttribution = fact.ImageAttribution;
            //vm.ImageHeight = fact.ImageHeight + "px";
            //vm.ImageWidth = fact.ImageWidth + "px";
            //vm.ImageUri = fact.ImageUri;

            return View(vm);
        }
    }
}