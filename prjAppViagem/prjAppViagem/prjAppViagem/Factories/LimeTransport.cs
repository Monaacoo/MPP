using prjAppViagem.Aircrafts;
using prjAppViagem.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Factories
{
    class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }
        public ILandVehicles CreateTransportVehicle(String Tipo)
        {
            if (Tipo == "produto")
            {
                return new Scooter();
            } else
            {
                return null;
            }
        }
    }
}
