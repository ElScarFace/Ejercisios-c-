using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, n3, nmy, nmn;
            string nombre, condicion;

            Console.WriteLine("Escriba su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba la 1º nota: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba la 2º nota: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba la 3º nota: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            double prom;
            prom = (n1 + n2 + n3) / 3;

            if (prom <= 5)
            {
                condicion = "Pesimo";
            }
            else if (prom <= 10)
            {
                condicion = "Malo";
            }
            else if (prom <= 15)
            {
                condicion = "Regular";
            }
            else if (prom <= 19)
            {
                condicion = "Bueno...";
            }
            else
            {
                condicion = "Excelente!!!";
            }

            nmy = n1;
            if (n2 >= nmy)
            {
                nmy = n2;
            }
            else if (n3 >= nmy)
            {
                nmy = n3;
            }
            else
            {
                nmy = n1;
            }

           
            nmn = n1;
            if (n2 < nmn)
            {
                nmn = n2;
            }
            else if (n3 < nmn)
            {
                nmn = n3;
            }
            else
            {
                nmn = n1;
            }

            Console.WriteLine("");
            Console.WriteLine("Nombre:     " + nombre);
            Console.WriteLine("Nota mayor: " + nmy);
            Console.WriteLine("Nota menor: " + nmn);
            Console.WriteLine("Promedio:   " + prom);
            Console.WriteLine("Condicion:  " + condicion);
            Console.ReadLine();
        }
    }
}
