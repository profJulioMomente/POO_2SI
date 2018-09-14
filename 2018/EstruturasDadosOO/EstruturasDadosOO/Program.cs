using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDadosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            EstruturaArrayList al = new EstruturaArrayList();
            EstruturaLista el = new EstruturaLista();
            EstruturaDataTable eDT = new EstruturaDataTable();
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] - Inserir");
                Console.WriteLine("[2] - Visualizar Quantidade");
                Console.WriteLine("[3] - Imprimir");
                Console.WriteLine("[4] - Procurar");
                Console.Write("Informe a opção desejada: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        eDT.adicionarDados();
                        break;
                    case 2:
                        //Console.WriteLine("Existem " + el.getQuantidadeElementos() + " elementos.");
                        break;
                    case 3:
                        eDT.imprimirDataTable();
                        break;
                    case 4:
                        //Console.Write("Informe o nome a ser localizado: ");
                        //string nome = Console.ReadLine();
                        //Pessoa p = el.procurarElemento(nome);
                        //p.imprimir();
                        break;
                    default:
                        continuar = false;
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (continuar);
        }
    }
}
