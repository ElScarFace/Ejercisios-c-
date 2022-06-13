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
            int n1;
            string idioma, traduc;

            Console.WriteLine("Escriba el Numero a Traducir (1-10): ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idioma: Español(sp),Ingles(en),Frances(fr): ");
            idioma = Console.ReadLine();

            if (n1 == 1)
            {
                if (idioma == "sp")
                {
                    traduc = "Uno";
                }
                else if (idioma == "en")
                {
                    traduc = "One";
                }
                else
                {
                    traduc = "Un";
                }
            }
            else if (n1 == 2)
            {
                if (idioma == "sp")
                {
                    traduc = "Dos";
                }
                else if (idioma == "en")
                {
                    traduc = "Two";
                }
                else
                {
                    traduc = "Deux";
                }
            }
            else if (n1 == 3)
            {
                if (idioma == "sp")
                {
                    traduc = "Tres";
                }
                else if (idioma == "en")
                {
                    traduc = "Three";
                }
                else
                {
                    traduc = "Trois";
                }
            }
            else if (n1 == 4)
            {
                if (idioma == "sp")
                {
                    traduc = "Cuatro";
                }
                else if (idioma == "en")
                {
                    traduc = "Four";
                }
                else
                {
                    traduc = "Cuatre";
                }
            }
            else if (n1 == 5)
            {
                if (idioma == "sp")
                {
                    traduc = "Cinco";
                }
                else if (idioma == "en")
                {
                    traduc = "Five";
                }
                else
                {
                    traduc = "Cinq";
                }
            }
            else if (n1 == 6)
            {
                if (idioma == "sp")
                {
                    traduc = "Seis";
                }
                else if (idioma == "en")
                {
                    traduc = "Six";
                }
                else
                {
                    traduc = "Six";
                }
            }
            else if (n1 == 7)
            {
                traduc = ""; if (idioma == "sp")
                {
                    traduc = "Siete";
                }
                else if (idioma == "en")
                {
                    traduc = "Seven";
                }
                else
                {
                    traduc = "Sept";
                }
            }
            else if (n1 == 8)
            {
                traduc = ""; if (idioma == "sp")
                {
                    traduc = "Ocho";
                }
                else if (idioma == "en")
                {
                    traduc = "Eight";
                }
                else
                {
                    traduc = "Huit";
                }
            }
            else if (n1 == 9)
            {
                traduc = ""; if (idioma == "sp")
                {
                    traduc = "Nueve";
                }
                else if (idioma == "en")
                {
                    traduc = "Nine";
                }
                else
                {
                    traduc = "Neuf";
                }
            }
            else if (n1 == 10)
            {
                traduc = ""; if (idioma == "sp")
                {
                    traduc = "Diez";
                }
                else if (idioma == "en")
                {
                    traduc = "Ten";
                }
                else
                {
                    traduc = "Dix";
                }
            }
            else
            {
                traduc = "----";
            }


            Console.WriteLine("");
            Console.WriteLine("Traduccion: " + traduc);
            Console.ReadLine();

        }
    }
}
