using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string producto, res = "si";
            double precio, pago, preciopro, preciom = 0, totalpagar = 0, sumapre = 0;
            int cantidad, cantidadpro = 0, n = 1;
            while (res == "si")
            {
                Console.WriteLine("\nNumero: " + n);
                Console.WriteLine("Producto:");

                producto = Console.ReadLine();
                Console.WriteLine("Precio:");

                precio = double.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");

                cantidad = int.Parse(Console.ReadLine());
                pago = precio * cantidad;
                Console.WriteLine("Importe a pagar: " + pago);

                sumapre = sumapre + precio;
                if (precio > preciom)
                {
                    preciom = precio;
                }
                totalpagar = totalpagar + pago;
                cantidadpro = n;

                Console.WriteLine("Desea seguir comprando si/no: \t");
                res = Console.ReadLine();

                n += 1;

            }
            preciopro = sumapre / cantidadpro;
            Console.WriteLine("Cantidad de productos: " + cantidadpro);
            Console.WriteLine("Promedio precio: " + preciopro);
            Console.WriteLine("Precio Mayor: " + preciom);
            Console.WriteLine("Total a Pagar: " + totalpagar);
            Console.ReadLine();
        }
    }
}
