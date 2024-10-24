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
            int a = 24, b = 36;

            while (a != b)
            {
                if (a > b)
                    a=a- b;
                else
                    b -= a;
            }
            Console.WriteLine("ekub=" + a);
            Console.ReadKey();
        }
    }
}
