using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class Pessoa
    {
        protected string Nome;
        protected string Endereco;

        public Pessoa()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Endereço: ");
            Endereco = Console.ReadLine();
        }

        public virtual void imprimir()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Endereço: " + Endereco);
        }

        public string getNome()
        {
            return Nome;
        }

        public void setNome (string Nome)
        {
            this.Nome = Nome;
        }

        public string getEndereco()
        {
            return Endereco;
        }

        public void setEndereco(string Endereco)
        {
            this.Endereco = Endereco;
        }

    }
}
