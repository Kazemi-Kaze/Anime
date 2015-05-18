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
        string check = "";
        //
        // GET: /anime/
       // [HttpGet]
        public ActionResult Index(string anime)
        {
            try
            {
               
                string result = new HttpClient().GetStringAsync("http://thetvdb.com/api/GetSeries.php?seriesname=" + anime).Result;
               

                if (result == "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\n<Data>\n</Data>")
                {
                     
                    return View("Home");
                }
                else
                {

                }
                XmlSerializer dims = new System.Xml.Serialization.XmlSerializer(typeof(animeapi.Data));

                animeapi.Data returnclass = (animeapi.Data)dims.Deserialize(new StringReader(result));
                return View(returnclass);
                
            }
            catch (Exception)
            {
                //string result = new HttpClient().GetStringAsync("http://services.tvrage.com/feeds/full_search.php?show=Naruto").Result;
                //string result = new HttpClient().GetStringAsync("http://thetvdb.com/api/GetSeries.php?seriesname=bleach").Result;
                //XmlSerializer dims = new System.Xml.Serialization.XmlSerializer(typeof(animeapi.Data));

                //animeapi.Data returnclass = (animeapi.Data)dims.Deserialize(new StringReader(result));


                //return View(returnclass);
                return View("Home");
                
            }
          
        }
        
        public ActionResult Home(string animes)
        {
           
            if (animes == null)
            {
                return View("");
            }

            if (check != "")
            {
                check = "";
                return RedirectToAction("Index"); 
            }
            

                //return RedirectToAction("Index");
                check = animes;
                return Index(animes);     
            
           
        }
   
    }
}
