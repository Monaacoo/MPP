using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProxy_BD
{
    public class PessoaDAO
    {
        //class faz acesso ao banco de dados

        public static IPessoa getPessoaByID(string id)
        {
            Console.WriteLine("select * from PESSOA where id= " + id);
            return new PessoaReal(id, "Pessoa " + id);
        }
    }
}
