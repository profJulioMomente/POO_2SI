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
            Dicionario D = new Dicionario();

            D.preencherDicionario();
            D.display();

            //TabelaHash TH = new TabelaHash();

            //for(int i=0; i<3; i++)
            //{
            //    Console.Write("Digite um nome: ");
            //    TH.adicionarNome(Console.ReadLine());
            //}

            //TH.displayHash();
            
            
            //TabelaDados T = new TabelaDados();
            
            //for(int i=0; i<3; i++)
            //{
            //    Pessoa P = new Pessoa();
            //    T.preencherTabela(P);
            //}

            //T.displayTabela();
            
            //ArrayL A = new ArrayL();
            //A.display();
            //Console.WriteLine(A.getElemento());


            //Lista L = new Lista();

            //L.display();
            ////Pessoa P1 = L.getElemento(20);

            ////P1.display();

            //ListaOrdenada L1 = new ListaOrdenada();
            //L1.display();

            Console.WriteLine("Pressione qualquer tecla para continuar ...");
            Console.ReadKey();
        }
    }
}
