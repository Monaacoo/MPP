using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProxy_BD
{
    public class PessoaProxy : IPessoa
    {
        private String id;
        private IPessoa pessoa;
        public PessoaProxy(String id) {
            this.id = id;
        }
        //Metodo comum da interface
        public String getNome()
        {
            
                if (pessoa == null)
                {
                    //Apenas cria o objeto real quando chamar este metodo
                    pessoa = PessoaDAO.getPessoaByID(this.id);
                }
            
            return pessoa.getNome();
        }
        public String getId()
        {
            return this.id;
        }
    }

}
