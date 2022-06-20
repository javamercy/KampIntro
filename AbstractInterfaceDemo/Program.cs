using AbstractInterfaceDemo.Abstract;
using AbstractInterfaceDemo.Adapters;
using AbstractInterfaceDemo.Concrete;
using AbstractInterfaceDemo.Entities;
using System;

namespace AbstractInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new FakeCheckAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2001, 7, 10),
                FirstName = "Emre",
                LastName = "Kurşun",
                NationalityId = "16345965492"
            }
            );


        }
    }
}
