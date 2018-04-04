using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2;

namespace LineasTest
{
    //TestClass]
    public class Linea3DTests
    {
        //[TestMethod]
        public void TestLong()
        {
            Punto3D[] puntos = new Punto3D[] { new Punto3D(0, 0, 0), new Punto3D(0, 2, 0), new Punto3D(0, 4, 0) };
            Linea3D linea3D = new Linea3D(puntos);
            Assert.AreEqual(4, linea3D.Longitud());
        }

        //[TestMethod]
        public void TestPuntoCercano()
        {
            Punto3D[] puntos = new Punto3D[] { new Punto3D(0, 0, 0), new Punto3D(0, 2, 0), new Punto3D(0, 4, 0) };
            Linea3D linea3D = new Linea3D(puntos);
            Assert.AreEqual(puntos[0], linea3D.PuntoMasCercano(new Punto3D(0, 1, 0)));
        }
    }
}
