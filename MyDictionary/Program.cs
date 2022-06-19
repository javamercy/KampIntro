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
            myCustomers.Add("Emrecan", 2);
            myCustomers.Add("Ahmet", 23);
            myCustomers.Add("Engin", 101);

            Console.WriteLine(myCustomers.Count);
            foreach (var key in myCustomers.Keys)
            {
                Console.WriteLine("Key: " + key);
            }

            foreach (var value in myCustomers.Values)
            {
                Console.WriteLine("Value: " + value);
            }

        }
    }
}
