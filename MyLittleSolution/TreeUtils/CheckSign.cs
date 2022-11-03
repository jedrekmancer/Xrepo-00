using System.Threading.Channels;

namespace TreeUtils
{
    public class CheckSign
    {
        public int val;
        private char e;

        public CheckSign(char _Sign, int _val)
        {
            char e = _Sign;

            if (e == '!' || e == '@' || e == '#' || e == '$' || e == '%' || e == '^' || e == '&' || e == '*' || e == ')')
            {
                return;
            }
            else
            {
                Console.WriteLine("oszukujesz, zamykam się i nie gadam z Tobą!");
            }

        }
        public static int suma (int a, int b)
        {
            int c;
            c = a + b;
            return c; 
        }

    }
}