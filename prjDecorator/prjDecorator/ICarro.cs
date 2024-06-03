using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDecorator
{
    public interface ICarro
    {
        void Ligar();

        void Dirigir();

        decimal ObterPreco();
    }
}
