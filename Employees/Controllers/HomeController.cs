using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employees.Models;
using Newtonsoft.Json;
using Employees.Entities;
using Employees.WebAPI.Controllers;
using Employees.Logic;

namespace Employees.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> getEmployees(int id)
        {
            EmployeesController a = new EmployeesController();
            List<Contract> listEmployeesContract = new List<Contract>();

            if (id == 0)
            {
                var ListEmployees = await a.Get();

                ContractFactory factory = null;                

                foreach (var i in ListEmployees.Value.ToList())
                {
                    if (i.contractTypeName == "HourlySalaryEmployee")
                        factory = new HourlyFactory(i.name, i.roleName, i.roleDescription, i.hourlySalary);
                    if (i.contractTypeName == "MonthlySalaryEmployee")
                        factory = new MonthlyFactory(i.name, i.roleName, i.roleDescription, i.monthlySalary);

                    listEmployeesContract.Add(factory.GetContract());
                }
            } else
            {
                var ListEmployees = await a.Get(id);

                ContractFactory factory = null;

                if (ListEmployees.Value.contractTypeName == "HourlySalaryEmployee")
                    factory = new HourlyFactory(ListEmployees.Value.name, ListEmployees.Value.roleName, ListEmployees.Value.roleDescription, ListEmployees.Value.hourlySalary);
                if (ListEmployees.Value.contractTypeName == "MonthlySalaryEmployee")
                    factory = new MonthlyFactory(ListEmployees.Value.name, ListEmployees.Value.roleName, ListEmployees.Value.roleDescription, ListEmployees.Value.monthlySalary);

                listEmployeesContract.Add(factory.GetContract());
            }

            var model = new ResultModel
            {
                ListEmployeesContract = listEmployeesContract,
            };

            return View("~/Views/Home/Result.cshtml", model);
        }
    }
}
