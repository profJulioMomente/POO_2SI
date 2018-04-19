using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Agencia Unilago = new Agencia();

            Conta C1 = new Conta(Unilago);

            C1.display("Teste");

            C1.depositar(123.45);
            Console.WriteLine("O saldo é : " + C1.getSaldo());
            C1.sacar(50.00);
            Console.WriteLine("O saldo é : " + C1.getSaldo());

            Console.WriteLine("\n\nPressione qualquer tecla para terminar ...");
            Console.ReadKey();

            Conta C2 = new Conta(Unilago, "99999");

            C2.display();

            C2.depositar(100);
            Console.WriteLine("O saldo é : " + C2.getSaldo());
            C2.sacar(58.20);
            Console.WriteLine("O saldo é : " + C2.getSaldo());

            Console.WriteLine("\n\nPressione qualquer tecla para terminar ...");
            Console.ReadKey();
        }
    }
}
