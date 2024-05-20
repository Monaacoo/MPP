using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subSistemaBanco
{
    public class FachadaBanco
    {
        private GerenciaLogin gerenciaLogin;
        private GerenciaTransacoes gerenciaTransacoes;

        public FachadaBanco()
        {
            gerenciaLogin = new GerenciaLogin();
            gerenciaTransacoes  = new GerenciaTransacoes(String nome, long matricula);
        }

        public void addUsuario (Usuario u) { 
            gerenciaLogin.addUsuario(u); 
        }

        public void deposito(long matricula, double valor)
        {
            Usuario usuario = gerenciaLogin.localizarUsuario(matricula);
            if (usuario != null)
            {
                gerenciaTransacoes.Deposito(valor, usuario);
                Console.WriteLine($"Depósito de {valor} realizado para o usuario {usuario.getNome()}");
            }
            else
            {
                Console.WriteLine("Usuario não encontrado.");
            }
        }
        public void saque(long matricula, double valor)
        {
            Usuario usuario = gerenciaLogin.localizarUsuario(matricula);
            if (usuario != null)
            {
                double novoSaldo = gerenciaTransacoes.Saque(valor, usuario);
                if (novoSaldo >= 0)
                {
                    Console.WriteLine($"Saque de {valor} realizado para o usuario {usuario.getNome()}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para realizar o saque.");
                }
            }
            else
            {
                Console.WriteLine("Usuario não encontrado.");
            }

        }

    }
}
