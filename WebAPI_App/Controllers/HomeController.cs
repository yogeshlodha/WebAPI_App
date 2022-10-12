using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_App.Models;
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

        /// <summary>
        ///     Get employee detail by employee id.
        /// </summary>
        /// <param name="empID">Employee ID</param>
        /// <returns>return either employee model</returns>
        public EmployeeModel GetEmployeeByID(int empID)
        {
            Employee objEmployee = new Employee();
            EmployeeModel empModel = new EmployeeModel();
            using (var emp = new DemoDBEntities())
            {
                empModel = emp.Employees.Where(x => x.Id == empID).Select(x=> new EmployeeModel { Id =x.Id, userName= x.userName, DOB = x.DOB }).FirstOrDefault();
            }
            return empModel;
        }

        /// <summary>
        ///     Get employee list. 
        /// </summary>
        /// <returns>return employee model list</returns>
        public List<EmployeeModel> GetEmployeeList()
        {
            Employee objEmployee = new Employee();
            List<EmployeeModel> empModel = new List<EmployeeModel>();
            using (var emp = new DemoDBEntities())
            {
                empModel = emp.Employees.Select(x => new EmployeeModel { Id = x.Id, userName = x.userName, DOB = x.DOB, IsActive = (bool)x.IsActive }).ToList();
            }
            return empModel;
        }

        /// <summary>
        ///     Change employee model delete status.
        /// </summary>
        /// <param name="empID">employee id</param>
        /// <returns>return last change status for employee.</returns>
        public bool ChangeDeleteEmployeeStatus(int empID)
        {
            Employee objEmployee = new Employee();
            EmployeeModel empModel = new EmployeeModel();
            using (var emp = new DemoDBEntities())
            {
                empModel = emp.Employees.Select(x => new EmployeeModel { Id = x.Id, userName = x.userName, DOB = x.DOB, IsActive = (bool)x.IsActive }).FirstOrDefault();
                empModel.IsActive = !empModel.IsActive;
                emp.SaveChanges();
            }
            return empModel.IsActive;
        }
    }
}
