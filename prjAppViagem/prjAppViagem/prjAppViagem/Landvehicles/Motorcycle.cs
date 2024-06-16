using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Landvehicles
{
    class Motorcycle : ILandVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Carregando produtos");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto com motorcycle");
        }
    }
}
