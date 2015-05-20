using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
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
        //public ActionResult Index(string anime)
        //{
        //    try
        //    {
               
        //        string result = new HttpClient().GetStringAsync("http://thetvdb.com/api/GetSeries.php?seriesname=" + anime).Result;
               

        //        if (result == "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\n<Data>\n</Data>")
        //        {
                     
        //            return View("Home");
        //        }
        //        else
        //        {

        //        }
        //        XmlSerializer dims = new System.Xml.Serialization.XmlSerializer(typeof(animeapi.Data));

        //        animeapi.Data returnclass = (animeapi.Data)dims.Deserialize(new StringReader(result));
        //        return View(returnclass);
                
        //    }
        //    catch (Exception)
        //    {
        //        //string result = new HttpClient().GetStringAsync("http://services.tvrage.com/feeds/full_search.php?show=Naruto").Result;
        //        //string result = new HttpClient().GetStringAsync("http://thetvdb.com/api/GetSeries.php?seriesname=bleach").Result;
        //        //XmlSerializer dims = new System.Xml.Serialization.XmlSerializer(typeof(animeapi.Data));

        //        //animeapi.Data returnclass = (animeapi.Data)dims.Deserialize(new StringReader(result));


        //        //return View(returnclass);
        //        return View("Home");
                
        //    }
          
        //}
        public ActionResult Index(string res)
        {

          
            string authInfo = "tessran2400:trevor2400";

            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));


            HttpClient request = new HttpClient();


            request.DefaultRequestHeaders.Add("Authorization", "Basic " + authInfo);


            string xmlStr = "";
            try
            {
                xmlStr = request.GetStringAsync("http://myanimelist.net/api/anime/search.xml?q="+res).Result;

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
            XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Mal.anime));
            Mal.anime ani;
            try
            {
                ani = (Mal.anime)serializer.Deserialize(new StringReader(xmlStr));
            }
            catch (Exception)
            {
                
                throw;
            }
         

            //anime deserialize = (anime)serializer.Deserialize(new StringReader(xmlStr));
           
            return View(ani);
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
