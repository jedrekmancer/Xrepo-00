using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_PROG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int s = int.Parse(Console.ReadLine());
            int k = s;
            int[] dane = new int[s] ;
            for (int i = 1; i < s ; i++)
            {
                dane[i-1] = i ;



                k = k * dane[i - 1];
                Console.WriteLine(dane[i-1]);
                Console.WriteLine(k);
            }





            
            
            Console.ReadKey();


        }
    }
}
            
