using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dupka1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę dupek");
            int liczbaDupek = int.Parse(Console.ReadLine());
            for (int i = 1; i <= liczbaDupek; i = i + 1)
            {
                Console.WriteLine(i + ". " + "Dupka");
            }
            Console.ReadLine();
            

            
        }
    }
}
