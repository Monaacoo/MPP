using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjComposite
{
    public class Morador : Component
    {
        public Morador(string nome) : base(nome) { }

        public override void Exibir()
        {
            Console.WriteLine($"Morador: {nome}");
        }
    }
}
