using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayL A = new ArrayL();
            //A.display();
            //Console.WriteLine(A.getElemento());


            //Lista L = new Lista();

            //L.display();
            ////Pessoa P1 = L.getElemento(20);

            ////P1.display();

            ListaOrdenada L1 = new ListaOrdenada();
            L1.display();

            Console.WriteLine("Pressione qualquer tecla para continuar ...");
            Console.ReadKey();
        }
    }
}
