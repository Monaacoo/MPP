using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAdapter
{
    public class HexagonoEstrangeiro
    {

        private double lado;

        public HexagonoEstrangeiro(double lado)
        {
            this.lado = lado;
        }

        public float calculaArea()
        {
            return (float)((3 * (lado * lado) * (float)Math.Sqrt(3)) / 2);
        }


    }

}
