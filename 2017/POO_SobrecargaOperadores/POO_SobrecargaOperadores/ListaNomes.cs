using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_SobrecargaOperadores
{
    class ListaNomes
    {
        List<string> Nomes;

        public ListaNomes()
        {
            Nomes = new List<string>();
        }

        public void addNome(string N)
        {
            Nomes.Add(N);
        }

        public void display()
        {
            foreach(string N in Nomes)
            {
                Console.WriteLine(N);
            }

            
        }
    }
}
