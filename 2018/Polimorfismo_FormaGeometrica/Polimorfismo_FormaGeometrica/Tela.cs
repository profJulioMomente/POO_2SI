using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_FormaGeometrica
{
    class Tela
    {
        private string Nome;

        public Tela()
        {
            Console.Write("Informe o nome da tela: ");
            Nome = Console.ReadLine();
        }

        public void desenhar(FormaGeometrica Forma)
        {
            Console.WriteLine(Forma.calcularArea());
        }
    }
}
