using System;

namespace Case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-2
             Kullanıcıdan 2 sayı isteyerek, bu sayıların toplamını bulan program
            */
            Console.WriteLine("1. Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());
            int toplam = sayi1 + sayi2;

            Console.WriteLine(sayi1 + " ve " + sayi2 + " Sayısının Toplamı : " + toplam);

        }
    }
}
