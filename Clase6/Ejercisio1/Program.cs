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
            int num;
            Console.WriteLine("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());
            suma(num);
            cantidad(num);


        }
        static void cantidad(int xnum)
        {
            int c;
            string can;
            can = xnum.ToString();
            c = can.Length;
            Console.WriteLine("Cantidad de digitos: " + c);
        }
        static void suma(int xnum)
        {
            int suma = 0;
            while (xnum != 0)
            {
                suma += xnum % 10;
                xnum /= 10;
            }
            Console.WriteLine("La suma es: " + suma);
            Console.ReadLine();
        }
       
      
    }

}
