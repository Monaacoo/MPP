using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace prjDecorator
{
    public abstract class CarDecorator : ICarro 
    {
        protected ICarro car;

        public CarDecorator(ICarro carro)
        {
            this.car = carro;
        }

        public virtual void Ligar()
        {
            car.Ligar();
        }

        public virtual void Dirigir()
        {
            car.Dirigir();
        }

        public virtual decimal ObterPreco()
        {
            return car.ObterPreco();
        }
    }
}
