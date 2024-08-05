using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCompositeEx1
{
    public class Organizacao :  HoraTrabalhada
    {
        private List<HoraTrabalhada> departamentos = new List<HoraTrabalhada>();
        public Organizacao(string nome) : base(nome) { }

        public override int GetHoraTrabalhada()
        {

            var horasTrabalhadasDepartamento = 0;
            Console.WriteLine($"Organização: {nome}");
            foreach (var departamento in departamentos)
            {
                horasTrabalhadasDepartamento += departamento.GetHoraTrabalhada();
                
            }
            Console.WriteLine("Horas trabalhadas: " + horasTrabalhadasDepartamento);
            return (horasTrabalhadasDepartamento);
        }
        public override void Adicionar(HoraTrabalhada horaTrabalhada)
        {
            departamentos.Add(horaTrabalhada);
        }

        public override void Remover(HoraTrabalhada horaTrabalhada)
        {
            departamentos.Remove(horaTrabalhada);
        }
    }
}
