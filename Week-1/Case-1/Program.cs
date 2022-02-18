using System;

namespace Case_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Alıştırma-1
             Ad ve soyad bilgisini string değişkenlere alarak ekrana */           
            
            Console.WriteLine("Adınız: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            string soyad = Console.ReadLine();

            Console.WriteLine("Merhaba " + ad + " " + soyad);
        }
    }
}
