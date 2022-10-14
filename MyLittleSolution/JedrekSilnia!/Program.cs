using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedrekSilnia_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Silnia zrobiona ze zwykłejn pętli
            Console.WriteLine("Program zwraca silnię liczby naturalnej");
            Console.WriteLine("Podaj liczbę:");
            int s = int.Parse(Console.ReadLine());
            int i, j;
            j = 1;
            
            for (i = s; i > 0; i = i - 1)
                {
                    j = j * i;
                }
            int wynik;
            wynik = j;


            Console.WriteLine(wynik);
            Console.ReadKey();



        }
    }
}
