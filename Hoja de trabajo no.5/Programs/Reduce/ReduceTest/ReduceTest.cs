using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reduce;
using System.Linq;

namespace ReduceTest
{
    [TestClass]
    public class ReduceTest
    {
        [TestMethod]
        public void ReduceIntTest()
        {
        
            int[] valores = new int[] { 2, 8, 9 };
            int reduce = Program.ReduceInt(valores, 0, (acc, valor) => acc + valor);

            Assert.AreEqual(reduce, 20);
        }

        [TestMethod]
        public void ReduceGenericTest()
        {
            //Suma la cantidad de veces que aparece la letra a en los elementos del arreglo
            string[] valores = new string[] { "Buenas", "tardes", "espero ganar" };
            int reduce = Program.Reduce(valores, 0, (acc, valor) => acc + valor.Where(c => c == 'a').Count());

            Assert.AreEqual(reduce, 10);
        }
    }
}
