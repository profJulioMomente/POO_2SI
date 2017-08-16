using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_SobrecargaOperadores
{
    class Vet
    {
        int[] V;
        int tam;

        public Vet()
        {
            Console.WriteLine("Informe o numero de elementos");
            tam = Convert.ToInt32(Console.ReadLine());

            V = new int[tam];

            for(int i=0; i< tam; i++)
            {
                Console.Write("V[" + i + "] = ");
                V[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public Vet(int v, int t)
        {
            tam = t;
            for (int i=0; i<tam; i++)
            {
                V[i] = v;
            }
        }

        public void display()
        {
            Console.WriteLine("\n");
            for(int i=0; i<tam; i++)
            {
                Console.WriteLine("V[" + i + "] = " + V[i]);
            }

        }

        public static Vet operator +(Vet V1, Vet V2)
        {
            int min;
            Vet max;
            
            if(V1.tam > V2.tam)
            {
                min = V2.tam;
                max = V1;
            } 
            else
            {
                min = V1.tam;
                max = V2;
            }
            

            for(int i=0; i<min; i++)
            {
                max.V[i] = V1.V[i] + V2.V[i];
            }

            return max;
        }

        public static Vet operator -(Vet V1 , Vet V2)
        {
            int min;
            Vet max;

            if (V1.tam > V2.tam)
            {
                min = V2.tam;
                max = V1;
            }
            else
            {
                min = V1.tam;
                max = V2;
            }

            
            for (int i = 0; i < min; i++)
            {
                max.V[i] = V1.V[i] - V2.V[i];
            }

            return max;
        }

        public static int operator *(Vet V1 , Vet V2)
        {
            int Res = 0;
            if (V1.tam == V2.tam)
            {
                for (int i = 0; i < V1.tam; i++)
                {
                    
                    Res += V1.V[i] * V2.V[i];
                }
            }
            else
            {
                Res = -1;
            }

            return Res;
        }
    }
}
