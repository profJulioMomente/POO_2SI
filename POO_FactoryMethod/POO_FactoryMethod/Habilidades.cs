using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_FactoryMethod
{
    class Habilidades : Pagina
    {

        public List<string> Habs = new List<string>();

        public Habilidades()
        {
            string H, opcao;

            do
            {
                Console.WriteLine("Informe uma Habilidade");
                H = Console.ReadLine();
                Habs.Add(H);
                Console.WriteLine("Dejesa inserir uma nova habilidade? [s/n]");
                opcao = Console.ReadLine();
                switch (opcao.ToUpper())
                {
                    case "S":
                        Console.Clear();
                        break;
                    case "N":
                        Console.WriteLine("Continuando ...");
                        break;
                    default:
                        Console.WriteLine("Entrada Invalida");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar ...");
                Console.ReadKey();

            } while (opcao != "N");
        }

        public override void exibirPagina()
        {
            Console.WriteLine("Pg: " + this.GetType().Name + "\n");
            //Console.WriteLine("Margens: [" + margemSuperior + "," + margemInferior + "," + margemEsquerda + "," + margemDireita+"]");
            //Console.WriteLine("Orientacao: " + orientacao);
            Console.WriteLine();
            foreach(string S in Habs)
            {
                Console.WriteLine(S);
            }
        }
    }
}
