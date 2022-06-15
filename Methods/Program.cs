using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(
                    urun.Adi + " : " +
                    urun.Fiyati + " TL" + " -> " +
                    urun.Aciklama);
            }

            Console.WriteLine("----------------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.SepeteEkle(urun1);
            sepetManager.SepeteEkle(urun2);
        }
    }
}
