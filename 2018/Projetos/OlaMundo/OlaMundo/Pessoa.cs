using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public void saudar()
        {
            Console.WriteLine("Olá Mundo!");
        }

        public void apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + Nome + ".");
        }

        public void obterInformacoes()
        {
            Console.Write("Informe seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            Idade = Convert.ToInt32(Console.ReadLine());

        }
    }
}
