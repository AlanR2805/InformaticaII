using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reduce
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int ReduceInt(int[] array, int primero, Func<int, int, int> reduce)
        {
            int acumulador = primero;

            for (int a = 0; a < array.Length; a++)
            {
                acumulador = reduce(acumulador, array[a]);
            }

            return acumulador;
        }

        public static A Reduce<T, A> (T[] array, A primero, Func<A, T, A> reduce)
        {
            A acumulador = primero;

            for (int i = 0; i < array.Length; i++)
            {
                acumulador = reduce(acumulador, array[i]);
            }

            return acumulador;
        }

    }
}
