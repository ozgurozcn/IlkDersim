﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya Baslangic Icin Temel Kurs";
            string kurs3 = "Java";

            // array - dizi
            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi",
                "Programlamaya Baslangic Icin Temel Kurs",
                "Java","C++"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Footer");
        }
    }
}
