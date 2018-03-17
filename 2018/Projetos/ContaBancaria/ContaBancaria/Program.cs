using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Agencia A = new Agencia();

            Console.WriteLine(A.getBanco() + " - Ag.: " + A.getNumero());
            Console.Write("Informe o novo telefone: ");
            string novoTelefone = Console.ReadLine();
            Console.Write("Informe o novo gerente: ");
            string novoGerente = Console.ReadLine();

            A.setTelefone(novoTelefone);
            A.setGerente(novoGerente);

            Console.WriteLine("\n\n");

            A.display();

            Console.WriteLine("\n\nPressione qualquer tecla para terminar ...");
            Console.ReadKey();
        }
    }
}
