using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    public class Tree
    {
        private string sign;
        private int baseWidth;
        private int lKloc = 1;
        private int lSpac;

        public Tree(string _sign, int _baseWidth)
        {
            sign = _sign;
            baseWidth = _baseWidth;
            lSpac = baseWidth / 2;
            
            for (int i = baseWidth; i >= 1; i -= 2)
            {

                for (int s1 = lSpac; s1 > 0 ; s1--)
                {
                    Console.Write(" ");
                }
                for (int k1 = lKloc; k1 > 0; k1--)
                {
                    Console.Write(sign);
                }

            Console.WriteLine();
                lKloc += 2;
                lSpac -= 1;

            }

        }

        static void Main(string[] args)
        {
            Tree drzewo1 = new Tree("$", 5);

            Console.ReadKey();
        }




        private void PrintSpac(int lSpac)
        {
            string spac = " ";
            lSpac = ((baseWidth + 1) / 2) - 1;
            for (int i = baseWidth; i >= 1; i = i - 2)
            {
                PrintSymb(spac, lSpac);
            }

        }

        private void PrintKloc(string kloc)
        {
            kloc = sign;
            for (int i = baseWidth; i >= 1; i = i - 2)
            {
                PrintSymb(kloc, lKloc);
            }

        }

        private void PrintSymb(string symb, int lSymb)
        {
            for (int i = 0; i <= lSymb; i++)
            {
                Console.Write(symb);
            }
        }

    }


}
