using System;

namespace Degiskenler1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // string ifadeler

            string str1 = string.Empty;
            str1 = "Emre YETİŞ";
            string ad = "Emre";
            string soyad = "YETİŞ";
            string tamIsim = ad + " " + soyad;
            Console.WriteLine(tamIsim);

            // integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            // boolean
            bool bool1 = 10 < 2;

            // Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);  // çıktısı 40

            int int22 = int20 + int.Parse(str20); // Çıktısı 40

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //saat
            string hour = DateTime.Now.ToString("hh.mm");
            Console.WriteLine(hour);

        }
    }
}