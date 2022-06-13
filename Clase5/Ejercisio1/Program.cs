using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n, resultado = 0;
           
            Console.WriteLine(" Ingrese un numero: \t");
            n = int.Parse(Console.ReadLine());
          
            while (n > 0)
            {
                resultado = resultado * 10 + n % 10;
                n /= 10;
            }
           
            Console.WriteLine("\nNumero invertido: " + resultado);
            Console.ReadLine();
        }
    }
}
