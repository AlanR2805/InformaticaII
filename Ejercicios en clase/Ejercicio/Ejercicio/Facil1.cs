using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Facil1
    {
        static void Main(string[] args)
        {
            string Palabra1 = " ", Palabra2 = "";
            Console.Write("Escriba una frase para invertir: ");
            Palabra1 = Console.ReadLine();
            for (int i = Palabra1.Length - 1; i >= 0; i--)
            {
                Palabra2 += Palabra1[i];
            }
            Console.Write("Frase invertida: " + Palabra2);
            Console.ReadKey();

        }
    }
}
