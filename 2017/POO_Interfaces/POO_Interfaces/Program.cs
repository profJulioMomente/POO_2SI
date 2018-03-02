using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();

            R.x = 1.5;
            R.y = 0;
            R.z = 0;

            R.lado1 = 4;
            R.lado2 = 6;

            Console.WriteLine("Área =" + R.area());
            Console.WriteLine("Coordenadas: " + R.x + "," + R.y + "," + R.z);

            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
