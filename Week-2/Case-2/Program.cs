using System;

namespace Case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-2
             1-N arasında 3 ve 7'ye tam bölünebilen sayıları listeleyen program
             */

            Console.WriteLine("Sayı Giriniz: ");
            int sayi= int.Parse(Console.ReadLine());

            for(int i = 1; i<= sayi; i++)
            {
                if(i % 3==0 && i % 7 == 0)
                {
                    Console.Write(" {0} ",i);
                }
            }
            Console.ReadKey();
        }
    }
}