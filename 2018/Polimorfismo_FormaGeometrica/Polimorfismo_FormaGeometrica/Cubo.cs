using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_FormaGeometrica
{
    class Cubo : FormaGeometrica
    {
        protected double lado;

        public Cubo()
        {
            Console.Write("Informe o lado: ");
            lado = Convert.ToDouble(Console.ReadLine());
        }

        public override double calcularArea()
        {
            return (6*lado*lado);
        }
    }
}
