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
            int n1;
            string mes, estacion;

            Console.WriteLine("Escriba un Numero (1-12): ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 >= 1 || n1 <= 12)
            {
                if (n1 == 1)
                {
                    mes = "Enero";
                    estacion = "Verano";
                }
                else if (n1 == 2)
                {
                    mes = "Febrero";
                    estacion = "Verano";
                }
                else if (n1 == 3)
                {
                    mes = "Marzo";
                    estacion = "Verano";
                }
                else if (n1 == 4)
                {
                    mes = "Abril";
                    estacion = "Otoño";
                }
                else if (n1 == 5)
                {
                    mes = "Mayo";
                    estacion = "Otoño";
                }
                else if (n1 == 6)
                {
                    mes = "Junio";
                    estacion = "Otoño";
                }
                else if (n1 == 7)
                {
                    mes = "Julio";
                    estacion = "Invierno";
                }
                else if (n1 == 8)
                {
                    mes = "Agosto";
                    estacion = "Invierno";
                }
                else if (n1 == 9)
                {
                    mes = "Septiembre";
                    estacion = "Invierno";
                }
                else if (n1 == 10)
                {
                    mes = "Octubre";
                    estacion = "Primavera";
                }
                else if (n1 == 11)
                {
                    mes = "Noviembre";
                    estacion = "Primavera";
                }
                else
                {
                    mes = "Diciembre";
                    estacion = "Primavera";
                }
            }
            else
            {
                mes = "Error";
                estacion = "Error";

            }

            Console.WriteLine("");
            Console.WriteLine("Mes:      " + mes);
            Console.WriteLine("Estacion: " + estacion);

            Console.ReadLine();
        }
    }
}
