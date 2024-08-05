using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCompositeEx1
{
    public abstract class HoraTrabalhada
    {
        protected string nome;
        public HoraTrabalhada(string nome)
        {
            this.nome = nome;
        }
        public abstract int GetHoraTrabalhada();
        public virtual void Adicionar(HoraTrabalhada horaTrabalhada) { }
        public virtual void Remover(HoraTrabalhada horaTrabalhada) { }
    }
}
