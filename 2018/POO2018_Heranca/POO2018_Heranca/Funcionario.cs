using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2018_Heranca
{
    abstract class Funcionario
    {
        private string Nome;
        protected string Matricula;

        public Funcionario() {}

        public Funcionario(int ctrl)
        {
            Console.Write("Informe o nome do funcionário: ");
            Nome = Console.ReadLine();

            Console.Write("Informe a matrícula do funcionário: ");
            Matricula = Console.ReadLine();
        }

        public void imprimirNome()
        {
            Console.WriteLine("Nome: " + Nome);
        }

        protected string getNome()
        {
            return Nome;
        }

        public void displayDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Matrícula: " + Matricula);
        }

        public abstract void calcularRendimento();
    }
}
