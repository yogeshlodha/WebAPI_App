using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//http://localhost:49200/api/home/get/1
namespace WebAPI_App.Controllers
{
    public class HomeController : ApiController
    {
        // GET: api/Home
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // http://localhost:49200/api/meta/home/hi?userName=yogesh
        [HttpGet]
        [ActionName("hi")]
        public string CustomURL(string userName)
        {
            return $"Welcome  {userName}";
        }

        // GET: api/Home/5
        [ActionName("GetString")]
        public string Get(int id)
        {

            return "Yogesh API Testing Page.";
        }

        // POST: api/Home
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
