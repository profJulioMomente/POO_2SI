using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class TabelaHash
    {
        Hashtable HT;

        public TabelaHash()
        {
            HT = new Hashtable();
        }

        public void adicionarNome(string Nome)
        {
           int chave = Nome.Length;

            HT.Add(chave , Nome);
        }

        public void displayHash()
        {
            Console.WriteLine(HT.ContainsValue("Fulano da Silva"));

            
            //foreach (DictionaryEntry d in HT)
            //{
            //    Console.WriteLine(d.Key + " - " + d.Value);
            //}
        }
    }
}
