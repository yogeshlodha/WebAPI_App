using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI_App.Models
{
    public class EmployeeModel
    {

            [Required]
            public int Id { get; set; }

            [StringLength(20, ErrorMessage = "Description Max Length is 20")]
            public string userName { get; set; }
            public System.DateTime DOB { get; set; }
            public bool IsActive { get; set; }

    }
}