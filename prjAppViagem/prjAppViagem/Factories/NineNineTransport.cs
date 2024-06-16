using prjAppViagem.Aircrafts;
using prjAppViagem.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Factories
{
    class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }
        public ILandVehicles CreateTransportVehicle(String Tipo)
        {
            if (Tipo == "produto")
            {
                return new Motorcycle();
            }
            else
            {
                return null;
            }
        }
    }
}
