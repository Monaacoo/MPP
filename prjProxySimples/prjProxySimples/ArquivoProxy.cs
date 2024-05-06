using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProxySimples
{
    public class ArquivoProxy : IArquivo
    {
        private IArquivo vrArquivo;
        private string NomeDoArquivo;

        public ArquivoProxy(string _nomedoarquivo) { 
            this.NomeDoArquivo = _nomedoarquivo;
            getArquivo();
        }
        public void getArquivo()
        {
            vrArquivo = new ArquivoReal(this.NomeDoArquivo);
            vrArquivo.getArquivo();
        }
    }
}
