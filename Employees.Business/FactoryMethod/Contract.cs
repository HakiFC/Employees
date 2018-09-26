using System;

namespace Employees.Logic
{
    public abstract class Contract
    {
        public abstract string ContractType { get; }
        public abstract string Name { get; set; }
        public abstract string RoleName { get; set; }
        public abstract string RoleDescription { get; set; }
        public abstract decimal AnnualSalary { get; set; }

    }
}
