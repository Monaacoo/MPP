using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjControladorEmail
{
    public class UsuarioB : IObservador
    {
        public void ReceberEmail(ISujeito sujeito)
        {
            Console.WriteLine("USUARIO: B\nUma nova mensagem na sua caixa de entrada!");
        }
    }
}
