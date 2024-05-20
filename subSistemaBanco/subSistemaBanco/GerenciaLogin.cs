using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subSistemaBanco
{
    public class GerenciaLogin
    {
        private List<Usuario> usuarios;

        public GerenciaLogin()
        {
            usuarios = new List<Usuario>();
        }

        public void addUsuario(Usuario u) { usuarios.Add(u); }

        public Usuario localizarUsuario(long matricula)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.getMatricula() == matricula) { return u; }
            }
            return null;
        }
    }
}
