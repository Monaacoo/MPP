using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCafe
{
    public class ChocolateDecorator : BebidaDecorator
    {
        public ChocolateDecorator(IBebida beb) : base(beb)
        {
            Console.WriteLine("Adicionando Chocolate");
        }

        public override string GetDescricao()
        {
            return beb.GetDescricao() + ", Chocolate";

        }

        public override double Custo()
        {
            return beb.Custo() + 0.75;
        }
    }
}
