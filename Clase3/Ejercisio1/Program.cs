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
            int n1, n2;
            string op, mensg;
            double rpta, resp;

            Console.WriteLine("Escriba el primer Numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba el segundo Numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba la Operacion deseada (+),(-),(*),(/): ");
            op = Console.ReadLine();

            Console.WriteLine("Escriba su Respuesta: ");
            resp = Convert.ToDouble(Console.ReadLine());


 
            if (op == "+")
            {
                rpta = n1 + n2;
            }
            else
            {
                if (op == "-")
                {
                    rpta = n1 - n2;
                }
                else
                {
                    if (op == "*")
                    {
                        rpta = n1 * n2;
                    }
                    else
                    {
                        if (op == "/")
                        {
                            rpta = n1 / n2;
                        }
                        else
                        {
                            rpta = 0;
                        }
                    }
                }
            }

     
            if (rpta == resp)
            {
                mensg = "La Respuesta es Correcta";
            }
            else
            {
                mensg = "La Respuesta es Incorrecta";
            }

            Console.WriteLine("");
            Console.WriteLine(mensg);
            Console.ReadLine();

        }
    }
}
