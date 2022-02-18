using System;

namespace Case_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-5
              Girilen sayının 0 ile 100 arasında olup,olmadığını kontrol eden program */

            Console.WriteLine("Bir sayı giriniz: ");

            int x = int.Parse(Console.ReadLine());

            if (x >= 0 && x <= 100)
            {
                Console.WriteLine(x + " sayisi 0 ile 100 arasındadır!");
            }
            else 
            {
                Console.WriteLine(x + " sayisi 0 ile yüz arasında DEĞİLDİR");
            }
        }
    }
}
