using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineasTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // polimorfismo en el que falla

            int[] arreglo = new int[] { };

            object polimorfismoFallido = arreglo;
        }
    }
}
