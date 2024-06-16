using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAdapter.Formas
{
    public class Quadrado : IPoligono
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public double getArea()
        {
            return lado * lado;
        }

       
    }
}
