using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_FormaGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela T1 = new Tela();
            FormaGeometrica forma;

            Console.WriteLine("Escolha uma das opções: ");
            Console.WriteLine("[1] - Ponto ");
            Console.WriteLine("[2] - Quadrado");
            Console.WriteLine("[3] - Cubo ");
            Console.WriteLine("[4] - Círculo ");
            Console.Write("Digite a opção desejada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    forma = new FormaGeometrica();
                    break;
                case 2:
                    forma = new Quadrado();
                    break;
                case 3:
                    forma = new Cubo();
                    break;
                case 4:
                    forma = new Circulo();
                    break;
                default:
                    forma = new FormaGeometrica();
                    break;
            }

            Console.Write("\nÁrea: "); 
            T1.desenhar(forma);

            
            
            Console.WriteLine("Pressione qualquer tecla para continuar ...");
            Console.ReadKey();

        }
    }
}
