using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProxyAuth
{
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada pasta;
        private Funcionario funcionario;
        public PastaCompartilhadaProxy(Funcionario funci)
        {
            funcionario = funci;
        }

        public void OperacaoDeLeituraGravacao()
        {
            if (funcionario.Perfil.ToUpper() == "CEO")
            {
                pasta = new PastaCompartilhada();
                Console.WriteLine("O Proxy 'Pasta Compartilhada' invoca a pasta real" +
                    " : 'metodo usado : OperacaoDeLeituraGravacao()'\n");
                pasta.OperacaoDeLeituraGravacao();
            }
            else
            {
                Console.WriteLine("O Proxy 'Pasta Compartilhada' avisa : " +
                    "'Voce nao tem permissao para acessar esta pasta'\n");
            }
        }
    }
}
