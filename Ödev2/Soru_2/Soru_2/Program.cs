using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyonlar_soru_2
{

    class Program
    {

        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            int index = 1;
            int maxIndex = 20;

            while (index <= maxIndex)
            {
                Console.WriteLine("{0}. sayıyı giriniz!", index++);

                try
                {
                    int number = int.Parse(Console.ReadLine());
                    for (int i = 0; i < maxIndex; i++)
                    {
                        arrayList.Add(number);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata : " + e.Message.ToString());
                    index--;
                    continue;

                }

            }

            arrayList.Sort();
            int[] kucukToplam = { Convert.ToInt32(arrayList[0]), Convert.ToInt32(arrayList[1]), Convert.ToInt32(arrayList[2]), Convert.ToInt32(arrayList[17]), Convert.ToInt32(arrayList[18]), Convert.ToInt32(arrayList[19]) };
            Console.WriteLine((arrayList[0], arrayList[1], arrayList[2]));
            Console.WriteLine("Küçük Ortalama :");
            Console.WriteLine((kucukToplam[0] + kucukToplam[1] + kucukToplam[2]) / 3);

            Console.WriteLine("Büyük Ortalama :");
            Console.WriteLine((arrayList[17], arrayList[18], arrayList[19]));
            Console.WriteLine((kucukToplam[3] + kucukToplam[4] + kucukToplam[5]) / 3);

            Console.WriteLine("Ortalama Toplamları :");
            Console.WriteLine(((kucukToplam[0] + kucukToplam[1] + kucukToplam[2]) / 3) + ((kucukToplam[3] + kucukToplam[4] + kucukToplam[5]) / 3));



        }
    }
}
