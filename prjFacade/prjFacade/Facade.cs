using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFacade
{
    public class Facade
    {
        //A classe Facade utiliza o padrao Facade e simplifica a inerface com o usuario
        // pois o mesmo cria uma instancia da classe Facade e chama o  metodo ConcederEmprestismo
        // que esconde a complexidade de consultar o SERASA, CADIN  e calcular o limite do credito

        private LimiteCredito limite = new LimiteCredito();
        private Serasa serasa = new Serasa();
        private Cadin cadin = new Cadin();

        public bool ConcederEmprestimo(Cliente cliente, double valor)
        {
            Console.WriteLine("{0} esta pleitando um emprestimo no valor de {1:C}\n",
                cliente.Nome, valor);
            bool ConcederEmprestimo = true;

            if (serasa.EstaNoSerasa(cliente))
            {
                //Verifica Serasa
                Console.WriteLine("Cliente " +  cliente.Nome + "possui restição no Serasa ");
                ConcederEmprestimo = false; 
            }
            else if (cadin.EstaNoCadin(cliente))
            {
                //Verifica Cadin
                Console.WriteLine("Cliente " + cliente.Nome + "possui restição no Cadin ");
                ConcederEmprestimo = false;
            }
            else if (!limite.PoussuiLimiteCredito(cliente, valor))
            {
                //verifica se o cliente tem limite de credito para o valor requerido
                Console.WriteLine("O cliente  {0} possui limite de credito inferior a {1:C}\n", cliente.Nome, valor);
                ConcederEmprestimo = false;
            }
            //True - concede false - nega
            return ConcederEmprestimo;

            
        }
    }
}
