using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Agencia
    {
        //Atributos
        private string Banco;
        private string Numero;
        private string Endereco;
        private string Telefone;
        private string Gerente;

        /// <summary>
        /// Método construtor da classe agência
        /// Faz a leitura dos valores dos atributos
        /// </summary>
        public Agencia()
        {
            Console.Write("Informe o banco: ");
            Banco = Console.ReadLine();
            Console.Write("Informe o número: ");
            Numero = Console.ReadLine();
            Console.Write("Informe o endereço: ");
            Endereco = Console.ReadLine();
            Console.Write("Informe o telefone: ");
            Telefone = Console.ReadLine();
            Console.Write("Informe o gerente: ");
            Gerente = Console.ReadLine();
        }

        //Métodos acessores
        public string getBanco()
        {
            return Banco.ToUpper();
        }

        public string getNumero()
        {
            return Numero;
        }

        public string getEndereco()
        {
            return Endereco;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public string getGerente()
        {
            return Gerente;
        }

        //Modificadores
        public void setEndereco(string Endereco)
        {
            this.Endereco = Endereco;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        public void setGerente(string Gerente)
        {
            this.Gerente = Gerente;
        }

        public void display()
        {
            Console.WriteLine(Banco);
            Console.WriteLine("Agencia: " + Numero);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Telefone: " + Telefone);
            Console.WriteLine("Gerente: " + Gerente);
        }
    }
}
