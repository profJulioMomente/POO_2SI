using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Dicionario
    {
        Dictionary<int , string> D;

        public Dicionario()
        {
            D = new Dictionary<int , string>();
        }

        public void preencherDicionario()
        {
            D.Add(1 , "POO");
            D.Add(2 , "LTP1");
            D.Add(3 , "ED");
        }

        public void display()
        {
            string valor;

            var chave = D.Where(c => c.Key == 1).Select(c => c.Value);

            //D.TryGetValue(4 , out valor);

            Console.WriteLine(chave);

            //foreach (KeyValuePair<int, string> par in D)
            //{
            //    Console.WriteLine(par.Key + " - " + par.Value);
            //}
        }

    }
}
