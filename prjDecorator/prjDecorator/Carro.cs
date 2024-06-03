using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDecorator
{
    class Carro : ICarro
    {
        public Carro() //contrutor
        {
            Console.WriteLine("Montando: contruir " + "chassi, adicionar peças principais");
        }

        public void Ligar()
        {
            Console.WriteLine("O motor da partida");
        }

        public void Dirigir()
        {
            Console.WriteLine("La vamos nos");
        }

        public decimal ObterPreco()
        {
            return 11000.00M;
        }
    }
}
