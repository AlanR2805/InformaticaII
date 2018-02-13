using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_De_Numeros_Intermedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] PrimerArray = new int[] { 1, 4, 6, 8, 9, 12 };
            int[] SegundoArray = new int[] { 0,3, 5,7,10 };

            int[] ArrayFinal = new int[PrimerArray.Length + SegundoArray.Length];

            bool next = true;
            int Array1I = 0;
            int Array2I = 0;
            int ArrayFinalI = 0;
            while (next)
            {
                if (PrimerArray.Length == 0 || SegundoArray.Length == 0)
                {
                    AddArreglo(PrimerArray, ArrayFinal, ArrayFinalI);
                    AddArreglo(SegundoArray, ArrayFinal, ArrayFinalI);
                    break;
                }
                if (PrimerArray[Array1I] < SegundoArray[Array2I])
                {
                    ArrayFinal[ArrayFinalI] = PrimerArray[Array1I];
                    PrimerArray = PrimerArray.Where(val => val != PrimerArray[Array1I]).ToArray();
                    ArrayFinalI++;
                }
                else
                {
                    ArrayFinal[ArrayFinalI] = SegundoArray[Array2I];
                    SegundoArray = SegundoArray.Where(val => val != SegundoArray[Array2I]).ToArray();
                    ArrayFinalI++;
                }
            }

            for (int i = 0; i < ArrayFinal.Length; i++)
            {
                Console.WriteLine(ArrayFinal[i]);
            }
            Console.ReadLine();
        }

        public static void AddArreglo(int[] arreglo, int[] arregloFinal, int start)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                arregloFinal[start] = arreglo[i];
                start++;
            }
        }
    }
    
}
