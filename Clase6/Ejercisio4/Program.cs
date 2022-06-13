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

            int dp, dp2;


            Console.WriteLine("Ingresar deposito 1: ");
            dp = int.Parse(Console.ReadLine());


            deposito(dp);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Ingresar deposito 2: ");
             dp2 = int.Parse(Console.ReadLine());

            deposito(dp2);
            Console.ReadKey();
        }
        static void deposito(int xdp)
        {
            int mr = 0, r = 0;
            while (xdp > 0)
            {
                Console.WriteLine("Ingresar monto a retirar: ");
                mr = int.Parse(Console.ReadLine());

                r = mr % 20;

                if (r == 0 && mr <= xdp)
                {
                    xdp -= mr;
               
                    Console.WriteLine("Saldo: " + xdp);
                }
                else
                {
                    Console.WriteLine("Valor Incorrecto: " + xdp);
                }
            }
        }
 

    }
}
