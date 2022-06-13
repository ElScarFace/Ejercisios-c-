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
           
            int n, inv = 0;
            string men;
            
            Console.WriteLine("Numero: ");
            n = int.Parse(Console.ReadLine());
           
            while (n > 0)
            {
                inv = inv * 10 + n % 10;
                n /= 10;
            }
            if (n == inv)
            {
                men = "Es Capicua";
            }
            else
            {
                men = "No es Capicua";
            }
            
            Console.WriteLine("\n" + men);
            Console.ReadLine();
        }
    }
}
