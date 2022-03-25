using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyonlar_soru_3
{

    class Program
    {

        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            List<string> cümle = new List<string>();

            string[] sesli = { "a", "e", "ı", "i", "o", "ö", "u", "ü" };

            Console.WriteLine("Bir cümle giriniz :");

            cümle.Add(Console.ReadLine());

            for (int i = 0; i < cümle.Count; i++)
            {
                for (int j = 0; j < sesli.Length; j++)
                {
                    if (cümle[i].Contains(sesli[j]))
                    {
                        list.Add(sesli[j]);
                    }
                }
                Console.WriteLine("Sesli Harfler Dizisi :");
                list.ForEach(e => Console.Write(e + " "));
            }
        }
    }
}