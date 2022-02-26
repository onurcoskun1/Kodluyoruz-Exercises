using System;

namespace Case_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-6
             * Bilgisayarın rastgele tuttuğu 10 sayıdan çift ve tek olanların sayısını gösteren program
             */

            int tekS=0, ciftS=0;
            Random rast = new Random();
            

            for (int i = 1; i<=10; i++)
            { 
                int sayi = rast.Next(1,100);
                Console.WriteLine(sayi);
                
                if(sayi % 2 == 0)
                {
                    ciftS++;
                }
                else
                {
                    tekS++;
                }
            }
            Console.WriteLine("Çift Sayı Adedi= {0}", ciftS);
            Console.WriteLine("Tek Sayı Adedi= {0}", tekS);
        }
    }
}
