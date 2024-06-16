using prjAppViagem.Aircrafts;
using prjAppViagem.Factories;
using prjAppViagem.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.App
{
    class Application
    {
        private IAircraft aircraft;
        private ILandVehicles vehicle;
        private string rota;
        public Application(ITransportFactory factory, string rota, string tipo)
        {
            this.rota = rota;
            if (rota == "terrestre")
            {
                vehicle = factory.CreateTransportVehicle(tipo);
            }
            else if (rota == "aereo")
            {
                aircraft = factory.CreateTransportAircraft();
            }
        }
        public void StartRoute()
        {
            if (rota == "terrestre")
                vehicle.StartRoute();

            else
                aircraft.StartRoute();
        }
    }
}
