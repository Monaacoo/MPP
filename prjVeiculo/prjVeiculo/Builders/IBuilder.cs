using prjVeiculo.Components;
using prjVeiculo.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeiculo.Builders
{
    interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetTransmission(Transmission transmission);
        void SetVehicleType(VehicleType vehicleType);
        void SetAirbag(int airbag);
    }
}
