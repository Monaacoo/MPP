using prjVeiculo.Builders;
using prjVeiculo.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace prjVeiculo.Directors
{
    class Director
    {

        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }
        public void ConstructSedanCar()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
            builder.SetAirbag(2);
        }

        public void ConstructTruck() {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.MANUAL);
            builder.SetAirbag(2);
        }

        public void ConstructSportCar()
        {
            builder.SetVehicleType(VehicleType.SPORTCAR);
            builder.SetEngine(new Engine(2400));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.AUTOMATIC_SEQUENCIAL);
            builder.SetAirbag(2);
        }
    }
}
