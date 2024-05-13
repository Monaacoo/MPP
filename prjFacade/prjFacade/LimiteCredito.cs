using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFacade
{
    public class LimiteCredito
    {
        public bool PoussuiLimiteCredito(Cliente cliente, double valor)
        {
            Console.WriteLine("Verificando o limite de credito do cliente " +  cliente.Nome);
            if (valor > 200000.00)
                return false;
            else
                return true;
        }
    }
}
