using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInterface
{
    public class Quadrado : IFormaGeometrica
    {
        private double lado;

        public double Lado { get => lado; set => lado = value; }

        public double area()
        {
            return (lado * lado);
        }
        public double comprimento()
        {
            return (4 * lado);
        }
    }
}