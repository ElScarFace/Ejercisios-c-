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
            string familia, condicion, seguro;
            int hijos, escolar;
            double      
           dinero = 0, dinescolar = 0, 
           conf = 0, seg = 0, total = 0;

            Console.WriteLine("Nombre de la Familia: ");
            familia = Console.ReadLine();

            Console.WriteLine("Escriba la Cant. de hijos: ");
            hijos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba Cant de hijos en edad escolar: ");
            escolar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Casada(c) o Viuda(v)");
            condicion = Console.ReadLine();

            Console.WriteLine("Posee Seguro Si(y) No(n):  ");
            seguro = Console.ReadLine();

 
            if (hijos <= 2)
            {
                dinero = 120;
            }
            else if (hijos <= 5 && hijos >= 3)
            {
                dinero = 150;
            }
            else if (hijos >= 6)
            {
                dinero = 180;
            }
            else
            {
                dinero = 0;
            }
         
            dinescolar = 20 * escolar;
        
            if (condicion == "c")
            {
                conf = 50;
                condicion = "Casada";
            }
            else
            {
                conf = 90;
                condicion = "Viuda";
            }
           
            if (seguro.Equals("y"))
            {
                seg = 0;
            }
            else
            {
                seg = 100;
            }
 
            total = dinero + dinescolar + conf + seg;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Mensualidad Dada: " + total);
            Console.ReadLine();
        }
    }
}
