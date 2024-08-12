using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExStrategy
{
    public class ClassConteudo
    {
        private IComissao icomissao;

        public ClassConteudo(IComissao icomissao)
        {
            this.icomissao = icomissao;
        }

        public void DefineStrategy(IComissao icomissao)
        {
            this.icomissao = icomissao;
        }

        public void ExecutaCalculo(double comissao)
        {
            icomissao.calcularComissao(comissao);
        }
    }
}
