using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDadosOO
{
    class EstruturaArrayList
    {
        private ArrayList estrutura;

        public EstruturaArrayList()
        {
            estrutura = new ArrayList();
        }

        public int getQuantidadeElementos()
        {
            return estrutura.Count;
        }

        public void inserirElemento(object valor)
        {
            estrutura.Add(valor);
        }

        public void imprimirElementos()
        {
            foreach(var elemento in estrutura)
            {
                Console.WriteLine(elemento.ToString());
            }
        }

        public int procurarElemento(object valor)
        {
            return estrutura.IndexOf(valor);
        }
    }
}
