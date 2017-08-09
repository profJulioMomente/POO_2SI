using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Interfaces
{
    interface IFormaGeometrica
    {
        
        double x { get; set; }
        double y { get; set; }
        double z { get; set; }

        double area();


    }
}
