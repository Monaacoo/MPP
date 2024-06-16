using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTransportFactory.Veiculos
{
    public class Car : Vehicle
    {
        void Vehicle.StartRoute()
        {
            Console.WriteLine("Iniciando o trajeto com carro");
        }
        void Vehicle.GetCargo()
        {
            Console.WriteLine("Carregando pessoas");
        }
    }
}
