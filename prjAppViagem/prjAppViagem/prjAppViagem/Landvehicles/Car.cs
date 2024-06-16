using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Landvehicles
{
    class Car : ILandVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Carregando pessoas");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto com carro");
        }
    }
}
