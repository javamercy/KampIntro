using AbstractInterfaceDemo.Abstract;
using AbstractInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceDemo.Concrete
{
    class FakeCheckAdapter : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            return true;
        }
    }
}
