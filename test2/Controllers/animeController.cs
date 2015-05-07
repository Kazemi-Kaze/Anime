using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using test2.Models;

namespace test2.Controllers
{
    public class animeController : Controller
    {
        //
        // GET: /anime/
       // [HttpGet]
        public ActionResult Index()
        {
            string result = new HttpClient().GetStringAsync("http://services.tvrage.com/feeds/full_search.php?show=Naruto").Result;
            XmlSerializer dims = new System.Xml.Serialization.XmlSerializer(typeof(ResultsShow));

            ResultsShow returnclass = (ResultsShow)dims.Deserialize(new StringReader(result));

          animeapi.Results returnclass = (animeapi.Results)dims.Deserialize(new StringReader(result));
          
          return View(returnclass);
        }

    }
}
