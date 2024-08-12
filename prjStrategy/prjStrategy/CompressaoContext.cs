using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStrategy
{
    public class CompressaoContext 
    {
        private ICompressao icompressao;
        public CompressaoContext(ICompressao icompressao)
        {
            this.icompressao = icompressao;
        }
        public void DefineStrategy(ICompressao icompressao)
        {
            this.icompressao = icompressao;
        }
        public void CriarArquivoCompactado(string nomeArquivo)
        {
            icompressao.ComprimirArquivo(nomeArquivo);
        }
    }
}
