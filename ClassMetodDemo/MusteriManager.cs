using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {

            Console.WriteLine(musteri.FirstName + " eklendi.");
        }

        public void Delete(int musteriId)
        {
            Console.WriteLine(musteriId+" idli muşteri silindi.");
        }

       
    }
}
