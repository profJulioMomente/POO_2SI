using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2018_Heranca
{
    class Empresa
    {
        private string RazaoSocial;
        private string CNPJ;
        private Funcionario[] F = new Funcionario[3];

        public Empresa(Funcionario F1, Funcionario F2, Funcionario F3)
        {
            Console.WriteLine("Empresa");
            Console.Write("Informe a Razão Social: ");
            RazaoSocial = Console.ReadLine();
            Console.Write("Informe o CNPJ: ");
            CNPJ = Console.ReadLine();
            F[0] = F1;
            F[1] = F2;
            F[2] = F3;
        }

        public void mostrarNomes()
        {
            for (int i= 0; i<3; i++)
            {
                F[i].displayDados();
            }
        }

        public void mostarNome(Funcionario F)
        {
            F.imprimirNome();
        }

        public void mostrarRendimentos()
        {
            for (int i = 0; i < 3; i++)
            {
                F[i].calcularRendimento();
            }
        }
    }
}
