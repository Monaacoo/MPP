using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAdapter.Formas
{
    public class Triangulo : IPoligono
    {
        private double altura;
        private double vbase; 
        
        public Triangulo (double altura, double pbase)
        {
            this.altura = altura;
            this.vbase = pbase;
        }

        public double getArea()
        {
            return altura * vbase;
        }
    }
}
