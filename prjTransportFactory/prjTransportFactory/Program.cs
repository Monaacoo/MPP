using prjTransportFactory.Transport;
using prjTransportFactory.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTransportFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarTransport carTransport = new CarTransport();
            carTransport.CreateTransport();
            carTransport.StartTransport();
            

            MotorcycleTransport motorcycleTransport = new MotorcycleTransport();
            motorcycleTransport.CreateTransport();
            motorcycleTransport.StartTransport();

        }

    }
}
