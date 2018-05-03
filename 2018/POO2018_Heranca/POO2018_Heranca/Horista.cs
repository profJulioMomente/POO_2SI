using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2018_Heranca
{
    class Horista : Funcionario
    {
        protected float ValorHora;

        public Horista() : base(0)
        {
            Console.Write("Informe o valor da hora: ");
            ValorHora = float.Parse(Console.ReadLine());

        }

        public new void displayDados()
        {
            imprimirNome();
            Console.WriteLine("Matrícula: " + Matricula);
            Console.WriteLine("Valor da Hora: " + ValorHora);
        }

        public override void calcularRendimento()
        {
            Console.Write("Informe a quantidade de horas: ");
            int QtdHoras = Convert.ToInt32(Console.ReadLine());
            float rendimento = QtdHoras * ValorHora;
            Console.WriteLine("Rendimento: " + rendimento);
        }
    }
}
