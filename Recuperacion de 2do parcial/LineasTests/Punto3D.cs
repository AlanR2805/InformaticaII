using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class Punto3D
    {
        private int v1;
        private int v2;
        private int v3;

        public Punto3D(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public double X { get; }

        public double Y { get; }



        public double Z { get; }
    }
}
