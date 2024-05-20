using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subSistemaBanco
{
    public class GerenciaTransacoes
    {
        private double saldo, novo_saldo;
        public GerenciaTransacoes(String nome, long matricula)
        {
            Usuario usuario = new Usuario(nome, matricula);
            saldo = usuario.getSaldo();
        }

        public double Deposito(double valor, Usuario usuario)
        {
            novo_saldo = saldo + valor;
            usuario.setSaldo(novo_saldo);
            return novo_saldo;
        }

        public double Saque(double valor, Usuario usuario)
        {
            novo_saldo = saldo - valor;
            usuario.setSaldo(novo_saldo);
            return novo_saldo;
        }
    }
}
