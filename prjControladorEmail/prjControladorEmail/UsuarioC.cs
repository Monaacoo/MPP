using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjControladorEmail
{
    public class UsuarioC : IObservador
    {
        public void ReceberEmail(ISujeito sujeito)
        {
            Console.WriteLine("USUARIO: C\nUma nova mensagem na sua caixa de entrada!");
        }
    }
}
