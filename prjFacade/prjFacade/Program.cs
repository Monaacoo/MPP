using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria uma instancia do Facade
            Facade concedeCredito = new Facade();

            //cria uma instancia de um novo cliente informando o nome
            Cliente cliente1 = new Cliente("Lucas");

            //Utiliza o Facade para verificar condições de concessão ou não
            bool resultado = concedeCredito.ConcederEmprestimo(cliente1, 200100);

            //exibir resultado
            Console.WriteLine("o emprestimo pleiteado pelo cliente " + cliente1.Nome + " foi " + 
                (resultado ? "Aprovado " :  "Negado"));

            //aguarda
            Console.ReadKey();
        }
    }
}
