using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            multiplo(num);
        }
        static void multiplo(int xnum)
        {
            int resul = 0, n = 0;

            while (true)
            {
                resul = xnum * n;
                if (resul > 10)
                {
                    break;
                }
                n += 1;

                Console.WriteLine("{0} * {1} = {2}", n, xnum, resul);
                Console.ReadLine();
            }
        }

    }
}
