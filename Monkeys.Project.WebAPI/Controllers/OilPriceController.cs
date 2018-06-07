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
            string request = @"<?xml version=""1.0"" encoding=""utf - 8"" ?>
            <soap:Envelope xmlns:xsi = ""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd = ""http://www.w3.org/2001/XMLSchema"" xmlns:soap = ""http://schemas.xmlsoap.org/soap/envelope/"">
                <soap:Body>
                  <CurrentOilPrice xmlns = ""http://www.pttplc.com/ptt_webservice/"" >
                     <Language>TH</Language>
                   </CurrentOilPrice>
                 </soap:Body>
            </soap:Envelope>";

            XDocument xDoc = XDocument.Load(new StringReader(request));
            var unwrappedResponse = xDoc.Descendants((XNamespace)"http://schemas.xmlsoap.org/soap/envelope/" + "Body").First().FirstNode;

            //string uri = "http://www.webservicex.net/stockquote.asmx/GetQuote?symbol=MSFT";
            string uriWebService = "http://www.pttplc.com/webservice/pttinfo.asmx?op=CurrentOilPrice";
            XDocument xmlResult = XDocument.Load(uriWebService);
            return Json(new { test = xmlResult.Root.Value });
        }
    }

}