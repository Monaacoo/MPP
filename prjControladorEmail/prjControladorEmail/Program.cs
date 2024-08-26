using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjControladorEmail
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISujeito controladorEmail = new ControladorEmail();
            UsuarioA usuarioA = new UsuarioA();
            controladorEmail.Registrar(usuarioA);
            UsuarioB usuarioB = new UsuarioB();
            controladorEmail.Registrar(usuarioB);
            UsuarioC usuarioC = new UsuarioC();
            controladorEmail.Registrar(usuarioC);

            controladorEmail.EnviarEmail();

            controladorEmail.Remover(usuarioB);

            controladorEmail.EnviarEmail();
        }
    }
}
