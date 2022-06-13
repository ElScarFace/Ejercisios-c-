using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dinero, total;
            int b100, b50, b20, b10, m5, m2;

            b100 = 0;b50 = 0;b20 = 0;
            b10 = 0;m5 = 0;m2 = 0;

            Console.WriteLine("Ingrese la cantidad de dinero: ");
            dinero = Convert.ToInt32(Console.ReadLine());
            total = dinero;
            if (dinero >= 100)
            {
                b100 = (dinero / 100);
                dinero = dinero - (b100 * 100);
            }
            if (dinero >= 50)
            {
                b50 = (dinero / 50);
                dinero = dinero - (b50 * 50);
            }
            if (dinero >= 20)
            {
                b20 = (dinero / 20);
                dinero = dinero - (b20 * 20);
            }
            if (dinero >= 10)
            {
                b10 = (dinero / 10);
                dinero = dinero - (b10 * 10);
            }
            if (dinero >= 5)
            {
                m5 = (dinero / 5);
                dinero = dinero - (m5 * 5);
            }
            if (dinero >= 2)
            {
                m2 = (dinero / 2);
                dinero = dinero - (m2 * 2);
            }

          
            Console.WriteLine("  Billetes de 100: " + b100);
            Console.WriteLine("  Billetes de 50 : " + b50);
            Console.WriteLine("  Billetes de 20 : " + b20);
            Console.WriteLine("  Billetes de 10: " + b10);
            Console.WriteLine("  Monedas de 5:    " + m5);
            Console.WriteLine("  Monedas de 2:    " + m2);
            Console.WriteLine("  Monedas de 1:    " + dinero);
            Console.ReadLine();
        }
    }
}
