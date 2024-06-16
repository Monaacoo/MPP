using prjAppViagem.Aircrafts;
using prjAppViagem.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Factories
{
    interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILandVehicles CreateTransportVehicle(String Tipo);
    }
}
