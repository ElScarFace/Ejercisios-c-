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
          
            int ni = 0;
            double p, sp = 0, suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                suma = suma + i;
                if (i % 2 == 0)
                {
                    sp = sp + i;
                }
                else
                {
                    ni = ni + 1;
                }
            }
            p = suma / 10;

            Console.WriteLine("10 primeros numeros");
            Console.WriteLine("");
            Console.WriteLine("El promedio es: " + p);
            Console.WriteLine("Suma de Pares: " + sp);
            Console.WriteLine("Cantidad impares: " + ni);
            Console.ReadLine();
        }
    }
}
