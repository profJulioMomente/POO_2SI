using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class ArrayL
    {
        public ArrayList exemplo_AL;
        
        public ArrayL()
        {
            exemplo_AL = new ArrayList();

            //exemplo_AL.Add("Fulano");
            //exemplo_AL.Add("Cicrano");
            //exemplo_AL.Add("Beltrano");

            exemplo_AL.Add('a');
            exemplo_AL.Add("Fulano");
            exemplo_AL.Add(3.156);

        }

        public  void display()
        {
            //olhando todas as strings do ArrayList
            //foreach (string s in exemplo_AL)
            //{
            //    Console.WriteLine(s);
            //}

            //Percorrendo a coleção com variável genérica
            foreach (var v in exemplo_AL)
            {
                Console.WriteLine(v);
            }
        }

        public string getElemento()
        {
            int pos = exemplo_AL.IndexOf("Fulano");
            string s = (string) exemplo_AL[pos];
            return s;
        }

    }
}
