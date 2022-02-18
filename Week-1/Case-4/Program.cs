using System;

namespace Case_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Alıştırma-4
               Girilen sayının tek mi, çift mi olduğunu bulan program */
            
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı ÇİFT!");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı TEK!");
            }
        }
    }
}
