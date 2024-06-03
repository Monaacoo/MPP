using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCafe
{
    public class AcucarDecorator : BebidaDecorator
    {
        public AcucarDecorator(IBebida beb) : base(beb)
        {
            Console.WriteLine("Adicionando Açucar");
        }

        public override string GetDescricao()
        {
            return beb.GetDescricao() + ", Açucar";
        }

        public override double Custo()
        {
            return beb.Custo() + 0.20;
        }
    }
}
