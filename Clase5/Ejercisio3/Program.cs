using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int edad, n = 0, nv = 0, nm = 0, ev = 0, em = 0;
            double porv, porm, promv, promm;
            string res = "si", sexo;

            while (res == "si")
            {
                n += 1;
                Console.WriteLine("Sexo: ");
                sexo = Console.ReadLine();
                Console.WriteLine("Edad: ");
                edad = int.Parse(Console.ReadLine());

                if (sexo == "m")
                {
                    nv += 1;
                    ev += edad;
                }
                if (sexo == "f")
                {
                    nm += 1;
                    em += edad;
                }
                Console.WriteLine("Desea continuar (si/no): ");
                res = Console.ReadLine();

            }
            porv = (nv * 100) / n;
            porm = (nm * 100) / n;
            promv = ev / nv;
            promm = em / nm;
            Console.WriteLine("Porcentaje Varones: " + (porv * 1) + "%");
            Console.WriteLine("Porcentaje Mujeres: " + (porm * 1) + "%");
            Console.WriteLine("Promedio Edad Varones: " + promv);
            Console.WriteLine("Promedio Edad Mujeres: " + promm);
            Console.ReadLine();
        }
    }
}
