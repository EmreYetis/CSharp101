using System;

namespace struct_kavrami
{

    class Program
    {

        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            //dikdortgen.kisaKenar = 3;
            //dikdortgen.uzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı    :{0}", dikdortgen.Alanhesapla());

            Dikdortgen_Struct dikdortgen_struct;
            dikdortgen_struct.kisaKenar = 3;
            dikdortgen_struct.uzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı    :{0}", dikdortgen_struct.Alanhesapla());
        }
    }

    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen()
        {
            kisaKenar = 3;
            uzunKenar = 4;
        }

        public long Alanhesapla()
        {
            return this.kisaKenar*this.uzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            kisaKenar = 3;
            uzunKenar = 4;
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }

        public long Alanhesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }
}
