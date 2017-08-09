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

        public double x
        {
            get
            {
                return x;
            }

            set
            {
                
            }
        }

        public double y
        {
            get
            {
                return y;
            }

            set
            {
               
            }
        }

        public double z
        {
            get
            {
                return z;
            }

            set
            {
                
            }
        }

        public double area()
        {
            return lado1 * lado2;
        }
    }
}
