using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProxySimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IArquivo arq01 = new ArquivoProxy("Arquivo01");

            IArquivo arq02 = new ArquivoProxy("Arquivo02");

            IArquivo arq03 = new ArquivoProxy("Arquivo03");

            Console.ReadKey();
        }
    }
}
