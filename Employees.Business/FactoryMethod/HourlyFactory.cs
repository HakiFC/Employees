using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Logic
{
    public class HourlyFactory : ContractFactory
    {
        private string _name;
        private string _roleName;
        private string _roleDescription;
        private decimal _annualSalary;

        public HourlyFactory(string name, string role, string roleDescription, decimal salary)
        {
            _name = name;
            _roleName = role;
            _roleDescription = roleDescription;
            _annualSalary = 120 * salary * 12;
        }

        public override Contract GetContract()
        {
            return new HourlyContract(_name, _roleName, _roleDescription,_annualSalary);
        }
    }
}
