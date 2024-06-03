using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDecorator
{
    public class ArDecorator : CarDecorator
    {
        public ArDecorator(ICarro car) : base(car) {
            Console.WriteLine("Montar: adicionar unidade de ar condicionado");
        }

        public override void Ligar()
        {
            car.Ligar();
            Console.WriteLine("O ar começou");
        }
    }
}
