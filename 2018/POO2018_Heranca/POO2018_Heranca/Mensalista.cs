using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2018_Heranca
{
    class Mensalista : Funcionario
    {
        protected double Salario;

        public Mensalista():base(0)
        {
            Console.Write("Informe o salário: ");
            Salario = Convert.ToDouble(Console.ReadLine());
        }

        public new void displayDados()
        {
            imprimirNome();
            Console.WriteLine("Matrícula: " + Matricula);
            Console.WriteLine("Salário: " + Salario);
        }

        public override void calcularRendimento()
        {
            Console.WriteLine("Rendimento: " + Salario);
        }

        public void Teste()
        {
            Console.WriteLine("Teste");
        }
    }
}
