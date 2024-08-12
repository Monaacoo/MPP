using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExStrategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClassConteudo ctx = new ClassConteudo(new ClassComissaoIndividual());
            Console.WriteLine("Informe o nome o valor:");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInforme o tipo de comissao");
            Console.WriteLine("1-Individual(Padrão) 2-Conjunto\n");
            var opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 2)
            {
                ctx.DefineStrategy(new ClassComissaoConjunta());
            }
            
            ctx.ExecutaCalculo(valor);
            Console.Read();


        }
    }
}
