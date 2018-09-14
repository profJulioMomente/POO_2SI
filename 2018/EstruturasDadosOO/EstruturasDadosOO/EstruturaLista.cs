using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDadosOO
{
    class EstruturaLista
    {
        private List<Pessoa> estrutura;

        public EstruturaLista()
        {
            estrutura = new List<Pessoa>();
        }

        public int getQuantidadeElementos()
        {
            return estrutura.Count;
        }

        public void inserirElemento(Pessoa valor)
        {
            estrutura.Add(valor);
        }

        public void imprimirElementos()
        {
            foreach (Pessoa elemento in estrutura)
            {
                elemento.imprimir();
            }
        }

        public Pessoa procurarElemento(string nome)
        {
            return estrutura.Find(p => p.Nome.Contains(nome));
        }
    }
}
