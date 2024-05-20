using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subSistemaBanco
{
    class Program
    {
        static void Main(string[] args)
        {           
            Usuario usuario1 = new Usuario("Breno", 121343);
            usuario1.setSaldo(2000);

            FachadaBanco fachada = new FachadaBanco();
            
            fachada.addUsuario(usuario1);
           
            fachada.deposito(121343, 500);
            fachada.saque(121343, 200);
            
            fachada.deposito(121343, 300);
            fachada.saque(121343, 2000); 
            
            fachada.saque(999999, 200);
        }
    }
}
