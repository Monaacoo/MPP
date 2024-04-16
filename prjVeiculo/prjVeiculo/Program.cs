using prjVeiculo.Builders;
using prjVeiculo.Directors;
using prjVeiculo.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);
            director.ConstructSedanCar();
            Vehicle sedan = builder.GetVehicle();
            Console.WriteLine($"Criando um veiculo do tipo: {sedan.VehicleType}"); 

            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();
            Console.WriteLine($"Criando um veiculo do tipo: {truck.VehicleType}");

            director.ConstructSportCar();
            Vehicle sport = builder.GetVehicle();
            Console.WriteLine($"Criando um veiculo do tipo: {sport.VehicleType}");

            Console.ReadLine();
        }
    }
}
