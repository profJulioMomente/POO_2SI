using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_SobrecargaOperadores
{
    class Vetor
    {
        public int[] V;
        public int tam;

        public Vetor()
        {
            Console.WriteLine("Informe o tamanho do Vetor");
            tam = Convert.ToInt32(Console.ReadLine());

            V = new int[tam];

            for(int i = 0; i < tam; i++)
            {
                Console.Write("V[" + i + "] = ");
                V[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void display()
        {
            for(int i=0; i< tam; i++)
            {
                Console.WriteLine("V[" + i + "] = " + V[i]);
            }
        }

        public static Vetor operator +(Vetor V1, Vetor V2)
        {
            int min;
            if(V1.tam < V2.tam)
            {
                min = V1.tam;
            } else
            {
                min = V2.tam;
            }

            for (int i=0; i<min; i++)
            {
                V1.V[i] += V2.V[i];
            }

            return V1;
        }
    }
}
