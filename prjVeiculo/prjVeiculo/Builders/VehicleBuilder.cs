using System;
using prjVeiculo.Products;
using prjVeiculo.Components;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeiculo.Builders
{
    class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle() { 
            Vehicle result = vehicle;
            Reset();
            return result;
        }
        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void SetEngine(Engine engine)
        {
            vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            vehicle.Seats = seats;
        }

        public void SetAirbag(int airbag)
        {
            vehicle.Airbag = airbag;
        }

        public void SetTransmission (Transmission transmisson)
        {
            vehicle.Transmission = transmisson;
        }

        public void SetVehicleType (VehicleType type)
        {
            vehicle.VehicleType = type;
        }
    }
}
