using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ziyaretçilerin isimlerini tutacak bir liste tanımlanıyor
        List<string> ziyaretciler = new List<string>();

        Console.Write("Kaç ziyaretçi gireceksiniz? ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        // Kullanıcıdan isimleri alıyoruz
        for (int i = 0; i < sayi; i++)
        {
            Console.Write($"{i + 1}. ziyaretçinin ismini girin: ");
            string isim = Console.ReadLine();
            ziyaretciler.Add(isim);
        }

        // Foreach ile isimleri yazdırıyoruz
        Console.WriteLine("\nZiyaretçilerin isimleri:");
        foreach (string isim in ziyaretciler)
        {
            Console.WriteLine(isim);
        }
    }
}
