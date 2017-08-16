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

            Vet A = new Vet();
            Vet B = new Vet();

            Vet R = A + B;
            R.display();

            Vet R2 = A - B;
            R2.display();

            int Res = A * B;
            Console.WriteLine("Resultado = " + Res + "\n");

            Console.WriteLine("Pressione qualquer tecla para continuar ...");
            Console.ReadKey();
        }
    }
}
