using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine("Urun adi: "+urun.Adi);
                Console.WriteLine("Fiyat: "+urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }
            Console.WriteLine("----------------------METOTLAR--------------------");
            SepetManager sepetmanager = new SepetManager();
            //encapsulation
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetmanager.Ekle2("Elma", "Yeşil elma", 12,9);
        }
    }
}



// Dont repeat yourself. - Kendini tekrar etme. - DRY
