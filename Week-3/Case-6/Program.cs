using System;
using System.Collections;

namespace Case_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-6
             * Girilen bir ismi bir dizide arayan ve bulunup/bulunmadığını kontrol eden program.
             */
            
            ArrayList dizi= new ArrayList(5);

            dizi.Add("Onur");
            dizi.Add("Ali");
            dizi.Add("Nevsel");
            dizi.Add("Cansu");
            dizi.Add("Cemre");
            

            Console.WriteLine("Aradığınız kişinin adı?:  ");
            string aranan= Console.ReadLine();

            if (dizi.Contains(aranan)==true)
            {
                Console.WriteLine("Aradığınız isim dizide mevcut");
            }
            else
            {
                Console.WriteLine("Böyle biri bulunamadı. ");
            }
            Console.Read();
        }
    }
}
