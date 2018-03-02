using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_FactoryMethod
{
    class Relatorio : Documento
    {
        public override void criarPaginas()
        {
            Paginas.Add(new Resumo());
            Paginas.Add(new Introducao());
            Paginas.Add(new Conclusao());
        }
    }
}
