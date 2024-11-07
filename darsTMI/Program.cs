using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darsTMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 24, b = 36, c=72, d=100;

            int ab = ekub(a, b);
            int cd = ekub(c, d);
            int natija = ekub(ab, cd);

            Console.WriteLine("ekub=" + natija);

            Console.WriteLine("ekuk=" + ekuk(a,b));

            Console.ReadKey();
        }

        public static int ekub(int a,int b)
        {

            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b -= a;
            }
            return a;
        }
        public static int ekuk(int a, int b)
        {
            int s = a * b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b -= a;
            }
            return s/a;
        }

    }
}
