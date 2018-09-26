using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Logic
{
    public abstract class ContractFactory
    {
        public abstract Contract GetContract();
    }
}
