using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            double sueldo;
            double v1, v2, v3 ,cv;
           

            Console.WriteLine("Ingrese su sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
           

            Console.WriteLine("Ingrese la 1º Venta: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Ingrese la 2º Venta: ");
            v2 = Convert.ToDouble(Console.ReadLine());
           

            Console.WriteLine("Ingrese la 3º Venta: ");
            v3 = Convert.ToDouble(Console.ReadLine());

            cv = (v1 + v2 + v3) * 0.1; 

            double total;
            total = sueldo + cv; 

         
       
            Console.WriteLine(" Venta 1:    " + v1);
            Console.WriteLine(" Venta 2:    " + v2);
            Console.WriteLine(" Venta 3:    " + v3);
            Console.WriteLine(" Comision:   " + cv);
            Console.WriteLine(" Pago Total: " + total);
            Console.ReadLine(); 
        }
    }
}
