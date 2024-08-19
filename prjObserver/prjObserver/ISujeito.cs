using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjObserver
{
    public interface ISujeito
    {
        void RegistrarObservador(IObservador obs);
        void RemoverObservador(IObservador obs);
        void NotificarObservadores();
    }
}
