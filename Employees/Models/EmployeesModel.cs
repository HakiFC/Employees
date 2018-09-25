using System;

namespace Employees.Models
{
    public class EmployeesModel
    {
        int id { get; set; }

        string name { get; set; }

        string contractTypeName { get; set; }

        int roleId { get; set; }

        string roleName { get; set; }

        string roleDescription { get; set; }

        int hourlySalary { get; set; }

        int monthlySalary { get; set; } }
}