using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_FormaGeometrica
{
    class Quadrado : FormaGeometrica
    {
        protected double lado;

        public Quadrado()
        {
            Console.Write("Informe o lado: ");
            lado = Convert.ToDouble(Console.ReadLine());
        }

        public override double calcularArea()
        {
            return (lado * lado);
        }
    }
}
