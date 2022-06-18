using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Emrecan", "Mustafa", "Sadık" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            List<string> names = new List<string>()
            {
                "Engin",
                "Emrecan",
                "Mustafa",
                "Sadık"
            };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            names.Add("ilker");
            Console.WriteLine(names[4]);
            Console.WriteLine(names.Count);

        }
    }
}
