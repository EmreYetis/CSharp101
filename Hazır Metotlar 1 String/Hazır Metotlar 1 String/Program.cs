using System;

namespace hazir_metotlar_string
{

    class Program
    {

        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";

            //Length Karakter sayısı
            Console.WriteLine(degisken);

            //ToUpper, ToLower (Karakterlerin hepsini büyütür yada hepsini küçültür)

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat (
            Console.WriteLine(string.Concat(degisken," Merhaba!"));

            //Compare
            //CompareTo (1. degisken 2. degiskenden daha büyük karakter sayısına sahipse 1 döner küçükse -1)

            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine(degisken2.Contains(degisken2));

            //EndsWith ( degiskenin sonuna ekler)
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));

            //StartsWith ( degiskenin başına ekler)
            Console.WriteLine(degisken.StartsWith("Hoşgeldiniz!"));

            //IndexOf (kelimenin geçtiği indexi bulur)
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Emre"));

            //LastIndexOf (kelimeyi veya harfi indexin en sonundaki index numarasını verir)
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert (verilen index numarasının başına ekler)
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //PadLeft, PadRight (degiskenin soluna veya sağına boşluk(veya başka karakter) ekler.(karakter sayısı + boşluk sayısı)
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove (10. karakterden sonrasını siler)
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3)); //5den başlayarak 3 karakter siler.
            Console.WriteLine(degisken.Remove(0,1)); //0 dan başlayarak 1 karakter siler

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split (boşluklar arasından n inci indexi getirir.)
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring (4. indexten başlayarak cümlenin sonuna kadar getirir.
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6)); //4. indexten başlayarak 6 karakter getirir.





        }
    }
}
