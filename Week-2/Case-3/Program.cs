using System;

namespace Case_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-3
              Girilen diziyi alfabetik olarak sıralayan program
             */


            int veriSay;
            Console.WriteLine("Veri adedi: ");
            veriSay = int.Parse(Console.ReadLine());

            string[] list = new string[veriSay];
            string yazi;

            for (int i=0; i<veriSay; i++)
            {
                Console.WriteLine(i + 1 + ". Veri Giriniz: ");
                yazi=Console.ReadLine();
                list[i]= yazi;
            }

            Array.Sort(list);
            Console.WriteLine();

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }

        }
    }
}
