using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrama
{
    class Facil2
    {
        public static bool SonAnagramas(string a, string b)
        {
            int var1, var2;
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    var1 = 0;
                    var2 = 0;
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i] == b[j])
                            var1++;
                        if (a[i] == a[j])
                            var2++;
                    }
                    if (var1 != var2)
                        return false;
                }
                return true;
            }
            else
                return false;
        }


        static void Main(string[] args)
            {
                while (true)
                {
                    string palabra1, palabra2;
                    Console.Write("Escribra una palabra: ");
                    palabra1 = Console.ReadLine();
                    if (palabra1.Length == 0)
                        break;
                    else
                    {
                        Console.Write("Escriba la segunda palabra: ");
                        palabra2 = Console.ReadLine();
                        if (SonAnagramas(palabra1, palabra2) == false)
                            Console.Write("No son anagramas.");
                        else
                            Console.Write("Son anagramas.");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            }
        
    }
}
