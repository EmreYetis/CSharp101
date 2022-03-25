using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace odev_1
{
    class Problem1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**** Problem1 ****");
            Console.WriteLine("Pozitif bir sayı giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. pozitif sayıyı giriniz:", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= sayiDizisi[diziUzunlugu - 1]; i++)
            {
                if (sayiDizisi[i] % 2 == 0)
                {
                    Console.WriteLine(sayiDizisi[i]);
                }
            }

            Console.WriteLine("**** Problem2 ****");
            Console.WriteLine("Pozitif iki sayı giriniz:");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[] nDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. pozitif sayıyı giriniz:", i + 1);
                nDizisi[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < nDizisi[n - 1]; i++)
            {
                if (nDizisi[i] % 2 == 0)
                {
                    Console.WriteLine(nDizisi[i]);
                }
                else if (nDizisi[i] == m)
                {
                    Console.WriteLine(nDizisi[i]);
                }
            }

            Console.WriteLine("**** Problem3 ****");
            Console.WriteLine("Pozitif bir tam sayı giriniz:");
            int a = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[a];


            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Lütfen {0}. kelimeyi giriniz:", i + 1);
                kelimeler[i] = Convert.ToString(Console.ReadLine());
            }

            Array.Reverse(kelimeler);
            foreach (var kelime in kelimeler)
            {
                Console.Write(kelime + " ");
            }

            Console.WriteLine("**** Problem4 ****");
            Console.WriteLine("Bir cümle yazınız:");
            string cümle = Console.ReadLine();
            string[] kacKelime = cümle.Split(' ');
            Console.WriteLine("Toplam kelime sayısı:" +kacKelime.Length);

            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ" + "abcçdefgğhiıjklmnoöprsştuüvyz";
            int sayac = 0;
            for (int i = 0; i < cümle.Length; i++)
            {
                if (liste.Contains(cümle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Toplam harf sayısı:" + sayac);
            
            









        }
    }

}
