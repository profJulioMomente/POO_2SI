using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Lista
    {
        public List<Pessoa> P;

        public Lista()
        {
            P = new List<Pessoa>();

            for(int i=0; i<3; i++)
            {
                Pessoa person = new Pessoa();
                P.Add(person);
            }
        }

        public void display()
        {
            
            foreach(Pessoa obj in P)
            {
                obj.display();
            }
        }

        public Pessoa getElemento(string N)
        {
            Pessoa retorno = P.Find(x => x.Nome == N);

            return retorno;
        }

        public Pessoa getElemento(int age)
        {
            Pessoa retorno = P.Find(x => x.idade == age);

            
            return retorno;
        }
    }
}
