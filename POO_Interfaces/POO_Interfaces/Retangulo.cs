using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Interfaces
{
    class Retangulo : IFormaGeometrica
    {
        public double lado1, lado2;

        private double X, Y, Z;
        public double x
        {
            get
            {
                return X;
            }

            set
            {
                X = value;
            }
        }

        public double y
        {
            get
            {
                return Y;
            }

            set
            {
                Y = value;
            }
        }

        public double z
        {
            get
            {
                return Z;
            }

            set
            {
                Z = value;
            }
        }

        public double area()
        {
            return lado1 * lado2;
        }
    }
}
