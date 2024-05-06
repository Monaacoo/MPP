using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace prjProxy_BD
{
    public class PessoaReal : IPessoa
    {
        private String nome;
        private String id;

        public PessoaReal(String id, String nome)
        {
            this.id = id;
            this.nome = nome;
            Console.WriteLine("Retornou a pessoa do banco de dados -> " + nome);
        }
        public String getId() {
            return this.id;
        }

        public String getNome() { 
            return nome;
        }

    }
}
