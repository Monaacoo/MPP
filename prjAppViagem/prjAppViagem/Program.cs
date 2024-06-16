using prjAppViagem.Factories;
using prjAppViagem.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem
{
    class Program
    {
        static Application ConfigureApplication()
        {
            Application app;
            ITransportFactory transportFactory;
            string company = "Uber";
            string rota = "terrestre";
            string tipo = "pessoa";
            if (company == "Uber")
            {
                transportFactory = new UberTransport();
            }
            else if (company == "99")
            {
                transportFactory = new NineNineTransport();
            }
            else if (company == "Lime")
            {
                transportFactory = new LimeTransport();
            }
            else
            {
                return null;
            }
            app = new Application(transportFactory, rota, tipo);
            return app;
        }
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();
            app.StartRoute();
            Console.ReadLine();
        }
    }
}
