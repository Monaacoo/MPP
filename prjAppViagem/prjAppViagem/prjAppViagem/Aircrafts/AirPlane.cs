using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Aircrafts
{
    class AirPlane : IAircraft
    {
        public void CheckWind()
        {

            Console.WriteLine("Ventos a 25km, ventos ok!");
        }
        public void GetCargo()
        {
            Console.WriteLine("Passageiros a bordo do aviao, vôo autorizado.");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Iniciando a decolagem.");
        }
    }
}
