using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Case_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-1
             * 1 ile 1000000 arasındaki asal sayıları listeleyen program
            */
            
            int correct=0;
            int counter=0;
            for (int i=2; i<1000000; i++)
            {
                correct=0;
                for (int j=2; j<i/2; j++)
                {
                    if (i % j == 0)
                    {
                        correct++;
                        break;
                    }
                }
                if (correct == 0)
                {
                    counter++;
                    Console.Write(i+"-");
                }
               
            }
            Console.WriteLine();
            Console.WriteLine("Bu sayı aralığında bulunan {0} adet asal sayı yukarıda listelenmiştir.", counter);
        }
    }
}
