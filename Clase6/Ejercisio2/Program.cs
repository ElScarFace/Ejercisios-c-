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
            int num;
            Console.WriteLine("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());
            extremas(num);
        }
        static void extremas(int xnum)
        {
            int resultado = 0;
            int ultimonum = xnum % 10;
            string c;
            while (xnum > 0)
            {
                resultado = resultado * 10 + xnum % 10;
                xnum /= 10;
            }
            int primernum = resultado % 10;
            c = primernum.ToString() + ultimonum.ToString();
            Console.WriteLine("Extremos: " + c);
         
            int ext = int.Parse(c);
            int inv = 0;
            while (ext > 0)
            {
                inv = inv * 10 + ext % 10;
                ext /= 10;
            }
            Console.WriteLine("Extremos Invertidas: " + inv);
            Console.ReadLine();
        }
 
    }
}
