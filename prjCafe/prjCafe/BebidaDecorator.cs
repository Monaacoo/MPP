using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCafe
{
    public abstract class BebidaDecorator : IBebida
    {
        protected IBebida beb;

        public BebidaDecorator(IBebida bebida)
        {
            this.beb = bebida;
        }

        public virtual string GetDescricao()
        {
             return beb.GetDescricao();
        }

        public virtual double Custo()
        {
            return beb.Custo();
        }


    }
}
