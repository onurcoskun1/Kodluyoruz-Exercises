using System;

namespace Case_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alıştırma-7
             * Kullanıcının girdiği metni kullanıcının girdiği sayıda ekrana yazdıran program
            */
            int count;
            Console.WriteLine("Ne yazdırmamı istersin?: ");
            string input=Console.ReadLine();
            Console.WriteLine("Kaç kez yazdırmamı istersin?: ");
            count = int.Parse(Console.ReadLine());
            

            for (int i=1; i<=count; i++)
            {
                Console.WriteLine(input);
            }


        }
    }
}
