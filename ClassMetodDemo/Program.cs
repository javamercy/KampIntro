using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Emrecan";
            musteri1.LastName = "Kurşun";
            musteri1.YearOfBirth = 2001;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.FirstName = "Engin";
            musteri2.LastName = "Demiroğ";
            musteri2.YearOfBirth = 1986;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.FirstName = "Mustafa Murat";
            musteri3.LastName = "Coşkun";
            musteri3.YearOfBirth = 1995;


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            musteriManager.Delete(2);

        }
    }
}
