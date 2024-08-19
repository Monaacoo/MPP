using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjObserver
{
    public class Assinante : IObservador
    {
       private Editora objetoObservado;

        public Assinante(Editora editora)
        {
            objetoObservado = editora;
            objetoObservado.RegistrarObservador(this);
        }

        public void Atualizar(ISujeito sujeito)
        {
            if (sujeito == objetoObservado)
            {
                Console.WriteLine("[Aviso] - A editora " + "alterou o seu estado para; " +
                    objetoObservado.getEdicao());
            }
        }
    }
}
