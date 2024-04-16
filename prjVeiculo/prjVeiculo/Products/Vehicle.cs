using prjVeiculo.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeiculo.Products
{
    public class Vehicle
    {
        private VehicleType vehicleType;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private int airbag;

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }
        public VehicleType VehicleType
        {
            get => vehicleType;
            set => vehicleType = value;
        }
        public int Seats
        {
            get => seats;
            set => seats = value;
        }
        public Transmission Transmission
        {
            get => transmission;
            set => transmission = value;
        }
        public int Airbag
        {
            get => airbag;
            set => airbag = value;
        }
    }
}
