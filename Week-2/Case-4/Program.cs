using System;

namespace Case_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma -4
             * Girilen metindeki sesli harf sayısını bulan program
            */
            Console.WriteLine("Bir metin giriniz: ");
            string metin=Console.ReadLine();

            string sesliHarfler = "aeıioöuü";

            int say=0;
            for(int i=0; i<metin.Length; i++)
            {
                if (sesliHarfler.Contains(metin[i]))
                {
                    say++;
                }
            }
            Console.WriteLine(metin);
            Console.WriteLine("Yukarıdaki ifadede toplam {0} adet sesli harf vardır", say);
            Console.ReadLine();
        }
    }
}
