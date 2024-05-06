using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProxy_BD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPessoa> pessoas = new List<IPessoa> { };
            //Cria cada Proxy para encapsular o acesso a classe "PessoaReal"
            pessoas.Add(new PessoaProxy("A"));
            pessoas.Add(new PessoaProxy("B"));
            pessoas.Add(new PessoaProxy("C"));

            Console.WriteLine("Nome: " + pessoas[0].getNome());
            //busca no banco de dados
            Console.WriteLine("Nome: " + pessoas[1].getNome());
            //busca no banco de dados
            Console.WriteLine("Nome: " + pessoas[0].getNome());
            //ja buscou esta pessoa... apenas retorna do cache

            Console.WriteLine("Id da terceira -  " + pessoas[2].getId());
            //pode imprimir o ID do objeto e o proxy nao sera inicializado
        }
    }
}
