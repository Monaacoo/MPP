using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInterface
{
    public class Circulo : IFormaGeometrica
    {
        private double raio;

        private static readonly double PI = 3.14;

        public double Raio { get => raio; set => raio = value; }

        public double area()
        {
            return (PI * raio * raio);
        }

        public double comprimento()
        {
            return (2 * PI * raio);
        }
    }
}