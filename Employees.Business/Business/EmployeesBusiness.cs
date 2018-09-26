using Employees.Data;
using Employees.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Logic
{
    public class EmployeesBusiness
    {
        public Connection data = new Connection();

        public async Task<List<EmployeesModel>> getEmployees()
        {
            var employees = await data.getEmployees();
            List<EmployeesModel> Employees = JsonConvert.DeserializeObject<List<EmployeesModel>>(employees);

            return Employees;
        }
    }
}
