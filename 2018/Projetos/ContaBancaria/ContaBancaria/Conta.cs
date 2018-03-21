using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Conta
    {
        private string Agencia;
        private string Numero;
        private string Titular;
        private string Senha;
        private double Saldo;


        public Conta()
        {
            Saldo = 0.0;
            Senha = "12345678";
            Random r = new Random();
            Numero = r.Next(10000 , 99999).ToString();


            Console.Write("Informe a agência: ");
            Agencia = Console.ReadLine();
            Console.Write("Informe o titular: ");
            Titular = Console.ReadLine();

        }

        public void display()
        {
            Console.WriteLine("Conta: " + Numero);
            Console.WriteLine("Agencia: " + Agencia);
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Saldo: " + Saldo);
        }

        public string getTitular()
        {
            return Titular;
        }

        public string getAgencia()
        {
            return Agencia;
        }
        public string getNumero()
        {
            return Numero;
        }

        public double getSaldo()
        {
            return Saldo;
        }

        public void setAgencia(string Agencia)
        {
            this.Agencia = Agencia;
        }

        public void setSenha(string Senha)
        {
            this.Senha = Senha;
        }

        public void depositar (double Valor)
        {
            if (Valor > 0)
            {
                Saldo += Valor;
            }
        }

        public void sacar(double Valor)
        {
            if (Valor > 0 && Saldo > Valor)
            {
                Saldo -= Valor;
            }
        }
    }
}
