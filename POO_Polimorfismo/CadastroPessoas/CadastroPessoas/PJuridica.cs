using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class PJuridica : Pessoa
    {
        protected string CNPJ;

        public PJuridica()
        {
            Console.Write("CNPJ: ");
            CNPJ = Console.ReadLine();
        }

        public override void imprimir()
        {
            base.imprimir();
            Console.WriteLine("CNPJ: " + CNPJ);
        }

        public string getCNPJ()
        {
            return CNPJ;
        }

        public void setCNPJ(string CNPJ)
        {
            this.CNPJ = CNPJ;
        }
    }
}
