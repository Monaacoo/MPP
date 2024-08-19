using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Editora editora = new Editora();
            Assinante assinante1 = new Assinante(editora);
            Assinante assinante2 = new Assinante(editora);
            Assinante assinante3 = new Assinante(editora);
            Assinante assinante4 = new Assinante(editora);
            Assinante assinante5 = new Assinante(editora);

            editora.alterarEdicao();

            editora.alterarEdicao();

            Console.ReadKey();
            
        }
    }
}
