using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IVeiculoMotorizado
    {
        string Potencia { get; set; } //Propriedade

        void darPartida(); //Assinatura de método
    }
}
