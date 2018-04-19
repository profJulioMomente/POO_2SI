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
            Mensalista M = new Mensalista();

            M.displayDados();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

        }
    }
}
