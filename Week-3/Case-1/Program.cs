using System;

namespace Case_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-1
             Klavyeden girilen bir cümlenin içerisindeki kelime sayısını bulan program
             */
            
            Console.WriteLine("Bir metin giriniz: ");
            string metin=Console.ReadLine();

            string[] kelimeler= metin.Split(' ');
            Console.WriteLine("Kelime sayısı= " +kelimeler.Length);

            foreach(string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            Console.Read();
        }
    }
}
