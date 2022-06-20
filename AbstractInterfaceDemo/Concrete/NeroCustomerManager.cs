using AbstractInterfaceDemo.Abstract;
using AbstractInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterfaceDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealCustomer(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Customer is unvalid!");
            }

        }
    }
}
