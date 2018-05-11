using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_FormaGeometrica
{
    class Circulo : FormaGeometrica
    {
        protected double raio;

        public Circulo()
        {
            Console.Write("Informe o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
        }


        public override double calcularArea()
        {
            return (3.14*raio*raio);
        }
    }
}
