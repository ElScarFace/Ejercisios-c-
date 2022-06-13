using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n, resul, suma = 0;
         
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= 12; i++)
            {
                resul = n * i;
                suma = suma + resul;
                Console.WriteLine(n + " * " + i + " = " + resul);
            }
         
            Console.WriteLine("La suma de los reusltados son: " + suma);
            Console.ReadLine();
        }
    }
}
