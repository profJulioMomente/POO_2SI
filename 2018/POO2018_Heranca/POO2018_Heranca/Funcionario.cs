using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2018_Heranca
{
    class Funcionario
    {
        protected string Nome;
        protected string Matricula;

        public Funcionario()
        {
            

        }

        public Funcionario(int ctrl)
        {
            Console.Write("Informe o nome do funcionário: ");
            Nome = Console.ReadLine();

            Console.Write("Informe a matrícula do funcionário: ");
            Matricula = Console.ReadLine();
        }
    }
}
