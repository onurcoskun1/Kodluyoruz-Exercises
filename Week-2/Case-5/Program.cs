using System;

namespace Case_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-5
             * Kullanıcıdan 10 adet sayı alarak bu sayıların toplamını ekranda gösteren program
             */
            
            int sayilar;
            int sum=0;

            for (int i=1; i<=10; i++)
            {
                System.Console.WriteLine("{0}. Sayıyı giriniz: ", i);
                sayilar=int.Parse(Console.ReadLine());
                sum = sum+sayilar;
            }
            Console.WriteLine("Toplam: " + sum);
            Console.WriteLine();

        }
    }
}
