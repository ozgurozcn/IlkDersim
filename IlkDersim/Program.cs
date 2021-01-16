using System;

namespace IlkDersim
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            string kategoriEtiketi = "Kategoriler"; // değer tutucu, alias - takma isim
            // don't repeat yourself - kendini tekrar etme
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45, dolarBugun = 7.35;
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("\\  /\n \\/");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Yukarı ok");
            }
            else
            {
                Console.WriteLine("Düz çizgi");
            }
            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Basariyla Giris Yapildi!");
            }
            else
            {
                Console.WriteLine("Giris Yapilmadi");
            }


        }
    }
}
