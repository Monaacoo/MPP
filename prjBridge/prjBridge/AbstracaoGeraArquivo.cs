using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridge
{
    public abstract class AbstracaoGeraArquivo
    {
        protected IGeraArquivo geraArquivo;
        protected AbstracaoGeraArquivo(IGeraArquivo geraArquivo) 
        {
            this.geraArquivo = geraArquivo;
        }
        public virtual void GravaArquivo(Funcionario funcionario) {
            geraArquivo.GravaArquivo(funcionario);
        }
    }
}
