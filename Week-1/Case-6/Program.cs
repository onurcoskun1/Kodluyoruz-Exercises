using System;

namespace Case_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Alıştırma-6
               Vücut kitle endeksi hesaplayan program */

            Console.WriteLine("Kilonuz(kg): ");
            double kilo = double.Parse(Console.ReadLine());
            Console.WriteLine("Boyunuz(cm): ");
            double boy = double.Parse(Console.ReadLine());
            boy = boy/100;


            double vke = kilo / (double)Math.Pow(boy, 2);

            if(vke < 18.5)
            {
                Console.WriteLine("Vücut Kitle Endeksiniz = " + vke);
                Console.WriteLine("Zayıfsınız!");
            }
            else if(vke >= 18.5 && vke <= 24.9)
            {
                Console.WriteLine("Vücut Kitle Endeksiniz = " + vke);
                Console.WriteLine("Kilonuz Normal!");
            }
           else if(vke >= 25 && vke < 30)
            {
                Console.WriteLine("Vücut Kitle Endeksiniz = " + vke);
                Console.WriteLine("Fazla Kilolusunuz!");
            }
            else if(vke >= 30 && vke < 35)
            {
                Console.WriteLine("Vücut Kitle Endeksiniz = " + vke);
                Console.WriteLine("Tip 1 Obez!");
            }
            else if(vke >= 35 && vke < 40)
            {
                Console.WriteLine("Vücut Kitle Endeksiniz = " + vke);
                Console.WriteLine("Tip 2 Obez!");
            }
            else if(vke > 40)
            {
                Console.WriteLine("Vücut Kitle Endeksiniz = " + vke);
                Console.WriteLine("Morbid Obez!");
            }
        }
    }
}
