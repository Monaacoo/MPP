using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjComposite
{
    public abstract class Component
    {
        protected string nome;
        public Component(string nome)
        {
            this.nome = nome;
        }
        public abstract void Exibir();
    }
}
