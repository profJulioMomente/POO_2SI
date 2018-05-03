using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2018_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mensalista");
            Mensalista M1 = new Mensalista();

            Console.WriteLine("Horista");
            Horista H1 = new Horista();

            Console.WriteLine("Funcionario");
            Funcionario F1 = new Funcionario(0);

            Console.WriteLine("Empresa");
            Empresa MinhaEmpresa = new Empresa(M1 , H1 , F1);

            MinhaEmpresa.mostrarRendimentos();


            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

        }
    }
}
