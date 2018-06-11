using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;
using System.Xml.Linq;

namespace Monkeys.Project.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/OilPrice")]
    public class OilPriceController : Controller
    {
        [HttpGet]
        [Route("GetCurrentOilPrice")]
        public JsonResult GetCurrentOilPrice()
        {
            var z = "";
            using (var xx = new PTTInfo())
            {
               z = xx.CurrentOilPrice("TH");
            }
            return Json(new { test = z });
        }
    }

}