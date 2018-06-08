using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Jetski : IVeiculoMotorizado,IVeiculoAquatico
    {
        public string Potencia
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void darPartida()
        {
            Console.WriteLine("Ligando hélice...");
        }

        public void Navegar()
        {
            Console.WriteLine("Acionando leme a estibordo...");
        }
    }
}
