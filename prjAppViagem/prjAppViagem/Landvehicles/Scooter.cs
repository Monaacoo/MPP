using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Landvehicles
{
    class Scooter : ILandVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Scooter carregada");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto com scooter");
        }
    }
}
