using System;

namespace Case_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Alıştırma-7
             * Girilen sıcaklık değerini Celcius'tan Fahrenheit'a çeviren program
             */
            
            Console.WriteLine("Bir sıcaklık değeri giriniz (°C): ");

            int derece=int.Parse(Console.ReadLine());

            int fah= (derece*9/5)+32;

            Console.WriteLine("{0}°C = {1}°F", derece, fah);
        }
    }
}
