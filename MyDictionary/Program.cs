using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> customers = new Dictionary<string, int>();
            customers.Add("Emrecan", 1);
            customers.Add("Ahmet", 1);
            customers.Add("Engin", 1);

            Console.WriteLine(customers.Count);
            

            MyDictionary<string, int> myCustomers = new MyDictionary<string, int>();
            myCustomers.Add("Emrecan", 1);
            myCustomers.Add("Ahmet", 1);
            myCustomers.Add("Engin", 1);

            Console.WriteLine(myCustomers.Count);
        }
    }
}
