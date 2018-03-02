using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class PFisica : Pessoa
    {
        protected string CPF;

        public PFisica()
        {
            Console.Write("CPF: ");
            CPF = Console.ReadLine();
        }

        public override void imprimir()
        {
            base.imprimir();
            Console.WriteLine("CPF: " + CPF);
        }

        public string getCPF()
        {
            return CPF;
        }

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }

    }
}
