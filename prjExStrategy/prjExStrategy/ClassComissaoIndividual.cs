using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExStrategy
{
    public class ClassComissaoIndividual : IComissao
    {
        public double calcularComissao(double comissao)
        {
            double total;
            total = comissao * 0.05;
            Console.WriteLine($"Valor da comissão do vendedor: {total}");
            return total;
        }
    }
}
