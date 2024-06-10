using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridge
{
    public class GeraSalario : AbstracaoGeraArquivo
    {
        public GeraSalario(IGeraArquivo geraArquivo) : base(geraArquivo) 
        {
            
        }

        public void ProcessaSalarioFuncinario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;

            Console.WriteLine($"Valor do salario total para o funcionario {funcionario.Id} \n" +
                $": R$ {funcionario.SalarioTotal}");
            geraArquivo.GravaArquivo(funcionario);
        }
    }
}
