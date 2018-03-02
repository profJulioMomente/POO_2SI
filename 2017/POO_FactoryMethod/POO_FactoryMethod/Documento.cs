using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_FactoryMethod
{
    abstract class Documento
    {
        private List<Pagina> pgs = new List<Pagina>();

        public Documento()
        {
            this.criarPaginas();
        }

        public List<Pagina> Paginas
        {
            get { return pgs; }
        }
        public abstract void criarPaginas();
    }
}
