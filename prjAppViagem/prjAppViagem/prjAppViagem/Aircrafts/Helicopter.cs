using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {

            Console.WriteLine("Ventos a 15km, ventos ok!");
        }
        public void GetCargo()
        {
            Console.WriteLine("Passageiros dentro do helicoptero, ativando helices.");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Iniciando a decolagem.");
        }
    }
}
