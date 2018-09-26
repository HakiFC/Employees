using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Logic
{
    class HourlyContract : Contract
    {
        private readonly string _contractType;
        private string _name;
        private string _roleName;
        private string _roleDescription;
        private decimal _annualSalary;      

        public HourlyContract(string name, string roleName, string roleDescription, decimal annualSalary)
        {
            _contractType = "Hourly";
            _name = name;
            _roleName = roleName;
            _roleDescription = roleDescription;
            _annualSalary = annualSalary;
        }

        public override string ContractType
        {
            get { return _contractType; }
        }

        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        public override string RoleDescription
        {
            get { return _roleDescription; }
            set { _roleDescription = value; }
        }

        public override decimal AnnualSalary
        {
            get { return _annualSalary; }
            set { _annualSalary = value; }
        }
    }
}
