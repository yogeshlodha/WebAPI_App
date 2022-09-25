using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebMVC_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string s;
            using (HttpClient client = new HttpClient())
            {
                string url = "http://localhost:49200/api/home/GetString/1";
                Uri uri = new Uri(url);
               System.Threading.Tasks.Task<HttpResponseMessage> result = client.GetAsync(uri);

                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();
                    ViewBag.result = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(response.Result); 
                }
            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}