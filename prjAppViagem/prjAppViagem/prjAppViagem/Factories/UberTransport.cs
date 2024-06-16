using prjAppViagem.Aircrafts;
using prjAppViagem.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Factories
{
    class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new AirPlane();
        }
        public ILandVehicles CreateTransportVehicle(String Tipo)
        {
            if (Tipo == "produto")
            {
                return new Motorcycle();
            }
            else if (Tipo == "pessoa")
            {
                return new Car();
            }
            else
            {
                return null;
            }
        }
    }
}
