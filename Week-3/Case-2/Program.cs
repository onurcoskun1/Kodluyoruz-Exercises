using System;

namespace Case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-2
             * Verilen bir karakter dizininin substring() metodunu kullanarak string
                içerisinde arama yapan ve kaç defa geçtiğini bulan program.
             */
            

            int counter=0;
            string metin="Bootcampe Onur girecek mi?";
            string aranan="Onur";

            int metinUzunluk=metin.Length;
            int arananUzunluk= aranan.Length;

            for (int i=0; i<=(metinUzunluk-arananUzunluk); i++)
            {
                if (metin.Substring(i, arananUzunluk) == aranan)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            Console.Read();
        }
    }
}
