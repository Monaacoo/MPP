using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTransportFactory.Veiculos
{
    public class Motorcycle : Vehicle
    {
        void Vehicle.StartRoute()
        {
            Console.WriteLine("Iniciando o trajeto com moto");
        }
        void Vehicle.GetCargo()
        {
            Console.WriteLine("Carregando produtos");
        }
    }
}
