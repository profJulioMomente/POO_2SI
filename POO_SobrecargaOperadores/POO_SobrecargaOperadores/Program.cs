using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_SobrecargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor A = new Vetor();
            Vetor B = new Vetor();

            Vetor R = A + B;

            R.display();

            Console.WriteLine("Pressione qualquer tecla para continuar ...");
            Console.ReadKey();
        }
    }
}
