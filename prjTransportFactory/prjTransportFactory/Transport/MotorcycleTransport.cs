using prjTransportFactory.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTransportFactory.Transport
{
    public class MotorcycleTransport : Transport
    {
        public override Vehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
