using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class Cadastro
    {
        Pessoa[] Usuarios;

        public Cadastro(int Qtdd)
        {
            Usuarios = new Pessoa[Qtdd];
        }

        public void CadastrarUsuario()
        {
            int opcao;
            for (int i=0; i<Usuarios.Length; i++)
            {
                Console.WriteLine("\n[1] - Pessoa Física, [2] - Pessoa Jurídica");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Usuarios[i] = new PFisica();
                        break;
                    case 2:
                        Usuarios[i] = new PJuridica();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }
        }

        public void mostrarTodos()
        {
            for(int i=0; i<Usuarios.Length; i++)
            {
                Console.WriteLine("\n");
                Usuarios[i].imprimir();
                
            }

        }

        //public void verNome(PFisica P)
        //{
        //    Console.WriteLine("Nome: " + P.getNome());
        //}

        //public void verNome(PJuridica P)
        //{
        //    Console.WriteLine("Nome: " + P.getNome());
        //}

        public void verNome(Pessoa P)
        {
            Console.WriteLine("Nome: " + P.getNome());
        }

    }
}
