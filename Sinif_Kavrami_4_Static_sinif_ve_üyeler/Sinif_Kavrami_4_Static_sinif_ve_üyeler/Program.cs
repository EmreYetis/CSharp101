using System;

namespace static_sinif_ve_uyeler
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Çlışan Sayısı:{0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe","Yılmaz","İK");
            Console.WriteLine("Çlışan Sayısı:{0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz", "Arda", "İK");
            Calisan calisan2 = new Calisan("Emre", "Yetiş", "İK");
            Console.WriteLine("Çlışan Sayısı:{0}", Calisan.CalisanSayisi);

            
            Console.WriteLine("Toplama İşlemi Sonucu: {0}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma İşlemi Sonucu: {0}", Islemler.Cıkar(400, 50));

        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string Isim;

        private string SoyIsim;

        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyIsim, string departman)
        {
            this.Isim = isim;
            this.SoyIsim = soyIsim;
            this.Departman  = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
