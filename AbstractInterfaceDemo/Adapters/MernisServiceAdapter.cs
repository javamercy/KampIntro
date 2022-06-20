using AbstractInterfaceDemo.Abstract;
using AbstractInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            return false;
        }
    }
}
