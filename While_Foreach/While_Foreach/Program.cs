using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den başlayarak consoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp konsola yazdıralım.
            Console.Write("Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0; ;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // a dan z ye kadar tüm harfleri konsola yazdır.
            char harfler = 'a';
            while (harfler <= 'z')
            {
                Console.Write(harfler);
                harfler++;
            }

            Console.WriteLine("**** Foreach ****");

            string[] arabalar = { "BMW", "Audi", "Ford", "Renault" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}