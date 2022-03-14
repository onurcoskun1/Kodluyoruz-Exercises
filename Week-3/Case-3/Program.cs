using System;

namespace Case_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-3
             * Klavyeden girilen bir sayı çift ise yarısını, tek ise 2 katını yazdıran program
             */
            
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi=int.Parse(Console.ReadLine());

            if(sayi % 2 == 0)
            {
                sayi= sayi/2;
            }
            else
            {
                sayi=sayi*2;
            }

            Console.WriteLine(sayi);

        }
    }
}
