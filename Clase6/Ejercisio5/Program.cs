using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingresar numero: ");
            num = int.Parse(Console.ReadLine());
            Multiplicar(num);
        }
        static void Multiplicar(int xnum)
        {
            int resul = 0;
            for (int i = 1; i <= 12; i++)
            {
                resul = xnum * i;
                Console.WriteLine("{0} * {1} = {2}", xnum, i, resul);
                Console.ReadLine();
            }
        }
  
    }
}
