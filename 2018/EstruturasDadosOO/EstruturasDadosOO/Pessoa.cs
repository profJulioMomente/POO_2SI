using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDadosOO
{
    class Pessoa
    {
        public string Nome;
        public string Cpf;
        public string Email;

        public Pessoa()
        {
            Console.WriteLine("Digite o nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF:");
            Cpf = Console.ReadLine();
            Console.WriteLine("Digite o e-mail:");
            Email = Console.ReadLine();
        }

        public void imprimir()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Cpf: " + Cpf);
            Console.WriteLine("e-mail: " + Email);

        }
    }
}
