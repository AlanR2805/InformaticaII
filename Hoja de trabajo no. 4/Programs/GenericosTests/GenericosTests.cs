using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosTest

{

    public class GenericosTest

    {
        public object Assert { get; private set; }

        public void HeadTest()

        {

            int[] arreglo = { 1, 2, 3 };

            Genericos generico = new Genericos();

            int valor = generico.Head<int>(arreglo);

            Assert.AreEqual(valor, arreglo[0]);

        }

        public void TailTest()
        {

            int[] ArregloBase = { 10, 20, 30, 40 };

            Genericos generico = new Generico();

            int[] NuevoArreglo = genericos.Tail<int>(ArregloBase);

            Assert.AreEqual(ArregloBase[0], NuevoArreglo[0]);

        }

        public void TestZip()
        {

            Genericos genericos = new Genericos();

            int[] a = { 1, 2, 3, 4 };

            int[] b = { 1, 2, 3, 4 };

            Tupla<int, int>[] arreglo = genericos.Zip<int, int>(a, b);



            for (int i = 0; i < arreglo.Length; i++)

            {

                Assert.AreEqual(a[i], arreglo[i].primero);

                Assert.AreEqual(b[i], arreglo[i].segundo);

            }

        }

    }

}
