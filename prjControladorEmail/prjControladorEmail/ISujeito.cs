using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjControladorEmail
{
    public interface ISujeito
    {
        void Remover(IObservador obs);
        void Registrar(IObservador obs);
        void EnviarEmail();
    }
}
