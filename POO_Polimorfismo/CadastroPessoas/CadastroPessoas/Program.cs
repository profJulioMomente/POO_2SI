using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPessoas;

            Console.WriteLine("Informe o número de pessoas");
            nPessoas = Convert.ToInt32(Console.ReadLine());

            Cadastro C = new Cadastro(nPessoas);

            C.CadastrarUsuario();

            Console.WriteLine("Pressione Qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            C.mostrarTodos();

            //PFisica J = new PFisica();
            //PJuridica U = new PJuridica();

            //J.imprimir();
            //U.imprimir();

            Console.WriteLine("Pressione Qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
