using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {

            Console.WriteLine("Ventos a 5km, ventos ok!");
        }
        public void GetCargo()
        {
            Console.WriteLine("Drone ativado, pronto para levantar voo.");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Iniciando a decolagem.");
        }
    }
}
