using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjControladorEmail
{
    public class ControladorEmail : ISujeito
    {
        private List<IObservador> observadores = new List<IObservador>();

        public void Registrar(IObservador obs)
        {
            observadores.Add(obs);
        }
        public void Remover(IObservador obs)
        {
            Console.WriteLine("Removendo o usuário: " + obs + " da lista");
            observadores.Remove(obs);
        }
        public void EnviarEmail()
        {
            foreach (IObservador obs in observadores)
            {
                obs.ReceberEmail(this);
            }
        }
    }
}
