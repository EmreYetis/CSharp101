using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyonlar_soru_1
{

    class Program
    {

        static void Main(string[] args)
        {
            ArrayList primeNum = new ArrayList();
            ArrayList notPrimeNum = new ArrayList();

            int index = 1;
            int lastIndex = 20;

            while (lastIndex > 0)
            {
                Console.WriteLine("{0}. sayıyı giriniz.", index++);

                try
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number > 1)
                    {
                        for (int i = 2; i < number; i++)
                        {
                            if (number % i == 0)
                            {
                                notPrimeNum.Add(number);
                                break;
                            }
                        }
                        if (!notPrimeNum.Contains(number))
                        {
                            primeNum.Add(number);
                        }
                        lastIndex--;
                    }
                    else
                    {
                        Console.WriteLine("Negatif sayı tespit edildi!");
                        index--;
                        continue;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata :" + e.Message.ToString());
                    index--;
                }


            }
            primeNum.Sort();
            notPrimeNum.Sort();
            int toplamPrime = 0;
            int toplamNotPrime = 0;
            foreach (int item in primeNum)
            {
                Console.WriteLine("Prime Number :" + item);
                toplamPrime += item;

            }
            foreach (int item in notPrimeNum)
            {
                Console.WriteLine("NotPrimeNumber :" + item);
                toplamNotPrime += item;

            }


            Console.WriteLine("Prime Length :" + primeNum.Count);
            Console.WriteLine("Average Prime :" + (toplamPrime / primeNum.Count));

            Console.WriteLine("NotPrime Length :" + notPrimeNum.Count);
            Console.WriteLine("Average NotPrime :" + (toplamNotPrime / notPrimeNum.Count));

        }
    }
}
