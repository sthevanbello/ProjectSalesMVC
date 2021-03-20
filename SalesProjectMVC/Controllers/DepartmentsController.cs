using Microsoft.AspNetCore.Mvc;
using SalesProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProjectMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listDepartment = new List<Department>();

            listDepartment.Add(new Department { Id = 1, Name = "Eletronics" });
            listDepartment.Add(new Department { Id = 2, Name = "Fashion" });

            return View(listDepartment);
        }
    }
}
