using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subSistemaBanco
{
    public class Usuario
    {
        private String Nome;
        private long Matricula;
        private double Saldo;

        public Usuario(String nome, long matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public void setNome(String nome)
        {
            this.Nome = nome;
        }

        public String getNome()
        {
            return Nome;
        }

        public void setMatricula(long matricula)
        {
            this.Matricula = matricula;
        }

        public long getMatricula()
        {
            return Matricula;
        }

        public void setSaldo(double saldo)
        {
            this.Saldo = saldo;
        }

        public double getSaldo()
        {
            return Saldo;
        }
    }
}
