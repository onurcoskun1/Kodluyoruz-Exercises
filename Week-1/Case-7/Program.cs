using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Case_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Alıştırma-7
               Cümledeki harf sayısını bulan program */

            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');
            char[] harfler = cumle.ToCharArray();

            char[] hSayisi = harfler.Where(x => x != ' ').ToArray();


            Console.WriteLine("Cümleniz {0} harften oluşmaktadır.", hSayisi.Length);
            Console.ReadKey();
        }
    }
}
