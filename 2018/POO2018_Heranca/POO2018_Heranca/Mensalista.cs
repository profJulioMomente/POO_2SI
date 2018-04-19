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

        public void displayDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Matrícula: " + Matricula);
            Console.WriteLine("Salário: " + Salario);
        }
    }
}
