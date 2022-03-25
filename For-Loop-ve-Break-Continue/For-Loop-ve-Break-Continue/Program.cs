using System;

namespace For_Loop_ve_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekranda girilen sayıya kadar olan tek sayıları yazdır.
            Console.WriteLine("Bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içinde toplanması
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("Tek Sayıların Toplamı:" + tekToplam);
            Console.WriteLine("Çift Sayıların Toplamı:" + ciftToplam);

            //Break,Continue
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);


            }
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);


            }
        }
    }
}