using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            GeraSalario calculaSalario = new GeraSalario(new GeraXML());

            Funcionario funcionario = new Funcionario
            {

                Id = 101,
                Name = "Gabriel",
                SalarioBase = 3000,
                Incentivo = 2000
            };
            calculaSalario.ProcessaSalarioFuncinario(funcionario);

            funcionario.Incentivo = 2500;

            calculaSalario = new GeraSalario(new GeraJSON());
            calculaSalario.ProcessaSalarioFuncinario(funcionario);
            Console.ReadLine();
            
        }
    }
}
