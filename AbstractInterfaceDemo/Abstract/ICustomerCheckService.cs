using AbstractInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealCustomer(Customer customer);
    }
}
