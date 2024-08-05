using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCompositeEx1
{
    public class Funcionario : HoraTrabalhada
    {
        public int id{
            get; set;
        }
        public int horas
        {
            get; set;
        }

        public Funcionario(string nome, int horas, int id) : base(nome) { 
            this.horas = horas;
            this.id = id;
        }

        public override int GetHoraTrabalhada()
        {

            Console.WriteLine($"Funcionario: {nome}, ID: {id}, Horas: {horas}");
            return (horas);
        }

    }
}
