using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC_App.Models
{
    public class EmployeeModel
    {
        public string userName { get; set; }
        public System.DateTime DOB { get; set; }
        public bool IsActive { get; set; }
    }
}