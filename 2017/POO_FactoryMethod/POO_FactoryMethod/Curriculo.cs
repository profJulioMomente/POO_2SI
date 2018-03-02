using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_FactoryMethod
{
    class Curriculo : Documento
    {
        public override void criarPaginas()
        {
            Paginas.Add(new Habilidades());
            Paginas.Add(new Experiencia());
            Paginas.Add(new Formacao());
        }
    }
}
