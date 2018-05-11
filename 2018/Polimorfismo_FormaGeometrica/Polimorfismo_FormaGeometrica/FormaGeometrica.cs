using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_FormaGeometrica
{
    class FormaGeometrica
    {
        protected double x;
        protected double y;
        protected double z;

        public FormaGeometrica()
        {
            Console.Write("Coordenada X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Coordenada Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Coordenada Z: ");
            z = Convert.ToDouble(Console.ReadLine());
        }

        public virtual double calcularArea()
        {
            return 0;
        }

    }
}
