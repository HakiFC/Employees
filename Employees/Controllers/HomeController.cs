using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employees.Models;
using Employees.Data;

namespace Employees.Controllers
{
    public class HomeController : Controller
    {
        public Connection data = new Connection();

        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> getEmployees()
        {
            var employees = await data.getEmployees();

            return employees.ToString();
        }
    }
}
