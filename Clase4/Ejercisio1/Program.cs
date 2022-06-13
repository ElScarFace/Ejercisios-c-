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
            double as1, as2, as3;
            double promedio, pmy = 0;
            string alumno, apmy = "";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nIngrese nombre del alumno " + (i + 1) + " :");
                alumno = Console.ReadLine();

                Console.WriteLine("Asignatura 1: ");
                as1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Asignatura 2: ");
                as2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Asignatura 3: ");
                as3 = double.Parse(Console.ReadLine());

                promedio = (as1 + as2 + as3) / 3;

                Console.WriteLine("Promedio: " + promedio);
                if (promedio > pmy)
                {
                    pmy = promedio;
                    apmy = alumno;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Alumno: " + apmy);
            Console.WriteLine("Promedio: " + pmy);
            Console.ReadLine();
        }
    }
}
