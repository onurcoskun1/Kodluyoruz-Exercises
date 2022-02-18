using System;

namespace Case_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Alıştırma-3
             Dikdörtgenin alanını ve çevresini hesaplayarak ekranda gösteren program */

            Console.WriteLine("Kısa Kenar: ");
            int kısa = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun Kenar: ");
            int uzun = int.Parse(Console.ReadLine());

            Console.WriteLine("Kısa Kenar: " + kısa);
            Console.WriteLine("Uzun Kenar: " + uzun);
            int alan = kısa * uzun;
            Console.WriteLine("Alan: " + alan);

            int cevre = 2*(kısa + uzun);
            Console.WriteLine("Çevre: " + cevre);
        }
    }
}
