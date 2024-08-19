using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjObserver
{
    public class Editora : ISujeito
    {
        private List<IObservador> observadores = new List<IObservador>();
        private bool novaEdicao = false;

        public void RegistrarObservador(IObservador obs)
        {
            observadores.Add(obs);
        }
        public void RemoverObservador(IObservador obs)
        {
            observadores.Remove(obs);
        }
        public void NotificarObservadores()
        {
            foreach (IObservador obs in observadores)
            {
                obs.Atualizar(this);
            }
        }
        public void alterarEdicao()
        {
            if (novaEdicao)
                novaEdicao = false;
            else
                novaEdicao = true; 
            NotificarObservadores();
        }
        public Boolean getEdicao()
        {
            return novaEdicao;
        }
    }
}
