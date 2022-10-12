using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebMVC_App.Models;

namespace WebMVC_App.Controllers
{
    public class HomeController : Controller
    {
        public string webApiURL = "http://localhost:49200/api/home/";
        public ActionResult Index()
        {
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

        public List<EmployeeModel> GetEmployeeList()
        {
            List<EmployeeModel> objEmpList = new List<EmployeeModel>();
            using (HttpClient client = new HttpClient())
            {
                string url = webApiURL + "GetEmployeeList";
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = client.GetAsync(uri);

                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();
                    objEmpList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<EmployeeModel>>(response.Result);
                }
            }
            return objEmpList;
        }

        public EmployeeModel GetEmployeeDetails(int empId)
        {
            EmployeeModel objEmp = new EmployeeModel();
            using (HttpClient client = new HttpClient())
            {
                string url = webApiURL + "GetEmployeeByID/"+empId;
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = client.GetAsync(uri);

                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();
                    objEmp = Newtonsoft.Json.JsonConvert.DeserializeObject<EmployeeModel>(response.Result);
                }
            }
            return objEmp;
        }

        public ActionResult ChangeEmployeeStatus(int empId)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = webApiURL+"ChangeDeleteEmployeeStatus/"+ empId;
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
    }
}