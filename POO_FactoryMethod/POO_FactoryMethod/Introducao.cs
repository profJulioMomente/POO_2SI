using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_FactoryMethod
{
    class Introducao : Pagina
    {
        public override void exibirPagina()
        {
            Console.WriteLine("Pg: " + this.GetType().Name + "\n");
            //Console.WriteLine("Margens: [" + margemSuperior + "," + margemInferior + "," + margemEsquerda + "," + margemDireita + "]");
            //Console.WriteLine("Orientacao: " + orientacao);
            Console.WriteLine();
        }
    }
}
