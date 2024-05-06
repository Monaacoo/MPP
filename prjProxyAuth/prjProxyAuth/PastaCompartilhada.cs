using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProxyAuth
{
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoDeLeituraGravacao()
        {
            Console.WriteLine("### Operação de leitura e escrita " + "na pasta compartilhada ###");
        }
    }
}
