using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAdapter
{
    class AdaptadorHexagono : IPoligono
    {
        private double lado;

        public AdaptadorHexagono(double lado)
        {
            this.lado = lado;
        }

        public double getArea()
        {
            HexagonoEstrangeiro hexagonoEstrangeiro = new HexagonoEstrangeiro(lado);

            return hexagonoEstrangeiro.calculaArea();
        }

    }
}
