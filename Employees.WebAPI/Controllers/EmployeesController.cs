using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.Logic;
using Employees.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Employees.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeesBusiness employeesBusiness = new EmployeesBusiness();

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<EmployeesModel>>> Get()
        {
            List<EmployeesModel> listEmployees = await employeesBusiness.getEmployees();

            return listEmployees;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeesModel>> Get(int id)
        {
            List<EmployeesModel> listEmployees = await employeesBusiness.getEmployees();

            EmployeesModel employee = listEmployees.Where(r => r.id == id).FirstOrDefault();

            return employee;
        }
    }
}
