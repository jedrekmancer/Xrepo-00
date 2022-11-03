using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeUtils
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

                for (int s1 = lSpac; s1 > 0; s1--)
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

    }

}
