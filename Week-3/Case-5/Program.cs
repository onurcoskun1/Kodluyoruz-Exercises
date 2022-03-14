using System;

namespace Case_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-5
             * 1-200 arasında girilen sayıya bölünebilen kaç adet sayı olduğunu yazdıran program
             */
            
            int count=0;
            Console.WriteLine("Bölen sayı= ");
            int sayi= int.Parse(Console.ReadLine());

            for (int i = 1; i<=200; i++)
            {
                if (i % sayi == 0)
                {
                    Console.WriteLine(i);
                    count=count+1;
                }
            }

            Console.WriteLine("1-200 arasında " + sayi + " sayısına bölünebilen " + count + " sayı bulunur.");
            Console.ReadKey();
        }
    }
}
