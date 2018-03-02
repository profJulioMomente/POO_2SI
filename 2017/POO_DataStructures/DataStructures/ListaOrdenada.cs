using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class ListaOrdenada
    {

        public SortedList S;


        public ListaOrdenada()
        {
            S = new SortedList();

            S.Add(2 , "Fulano");
            S.Add(3 , "Cicrano");
            S.Add(1 , "Beltrano");
            S.Add(-1, "Fulano da Silva");
        }

        public void display()
        {
            foreach(var v in S.Values)
            {
                Console.WriteLine(v);
            }

        }
    }
}
