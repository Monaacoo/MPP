using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExStrategy
{
    public class ClassComissaoConjunta : IComissao
    {
        public double calcularComissao(double comissao)
        {
            double total, partes;
            total = comissao * 0.05;
            partes = total * 0.5;

            Console.WriteLine($"Valor da comissão total: {total}" +
                $"\nValor da comissão do setor comercial: {partes}" +
                $"\nValor da comissão do vendedor: {partes}");

            return total;
        }
    }
}
