using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Pessoa
    {
        public string Nome;
        public int idade;
            

        public Pessoa()
        {
            Console.Write("Informe o nome: ");
            Nome = Console.ReadLine();
            Console.Write("Informe a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + idade);
        }
    }
}
