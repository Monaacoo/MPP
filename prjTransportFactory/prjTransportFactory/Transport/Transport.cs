using prjTransportFactory.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTransportFactory.Transport
{
    public abstract class Transport
    {
        public void StartTransport()
        {
            Vehicle vehicle = CreateTransport();
            vehicle.GetCargo();
            vehicle.StartRoute();
        }
        public abstract Vehicle CreateTransport();
    }
}
