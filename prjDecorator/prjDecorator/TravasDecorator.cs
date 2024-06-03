using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDecorator
{
    public class TravasDecorator : CarDecorator
    {
        public TravasDecorator(ICarro car) : base(car) {
            Console.WriteLine("Montar: adicionar travas eletricas");
        }

        public override void Dirigir()
        {
            car.Dirigir();
            Console.WriteLine("As portas travam automaticamente");
        }

    }
}
