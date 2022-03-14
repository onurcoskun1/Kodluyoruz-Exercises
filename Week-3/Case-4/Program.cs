using System;

namespace Case_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-4
             * Girilen sayının faktöriyelini hesaplayan program
             */
            
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi= int.Parse(Console.ReadLine());

            int value=1;

            for(int i = 1; i <= sayi; i++)
            {
                value = i*value;
            }

            Console.WriteLine("{0} faktöriyel = " + value, sayi);
            Console.Read();
        }
    }
}
