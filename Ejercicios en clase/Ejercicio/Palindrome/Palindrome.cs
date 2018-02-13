using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        const int palindrome = 1;
        const int nopalindrome = 0;

        static void Main(string[] args)
        {
            
            char[] carateres;
            Console.WriteLine("Ingrese una palabra: ");
            string Palabra = Console.ReadLine();
            Console.WriteLine("Ingrese segunda palabra: ");
            string Palabra2 = Console.ReadLine();

            carateres = new char[Palabra.Length];
            carateres = Palabra.ToCharArray(0, Palabra.Length);
            if (verificar(0, carateres, Palabra.Length) == palindrome) { 
                Console.WriteLine("la palabra es palindrome...");
                Console.ReadLine();  }
            else {
            Console.WriteLine("La palabra no es palindrome...");
                Console.ReadLine();
            }


        }

        static int verificar(int pos, char[] palabra, int largo)
        {
            if (palabra[pos] == palabra[largo - pos - 1])
            {
                if (pos < largo - pos)
                    return (verificar(++pos, palabra, largo));
                else
                    return (palindrome);
            }
            
            return (nopalindrome);
        }
    }
}
