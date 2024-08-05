using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCompositeEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var organizacao = new Organizacao("Brota no meu setor");
            var departamento01 = new Organizacao("101");
            var departamento02 = new Organizacao("102");

            var funcionario101_1 = new Funcionario("Angela", 6, 1);
            var funcionario101_2 = new Funcionario("Marilia",8,2);
            var funcionario101_3 = new Funcionario("Breno", 200, 9);

            var funcionario102_1 = new Funcionario("Lucas", 2, 3);
            var funcionario102_2 = new Funcionario("Isabela", 0, 5);
            var funcionario102_3 = new Funcionario("Gabriel", 74, 4);

            organizacao.Adicionar(departamento01);
            organizacao.Adicionar(departamento02);

            departamento01.Adicionar(funcionario101_1);
            departamento01.Adicionar(funcionario101_2);
            departamento01.Adicionar(funcionario101_3);
       

            departamento02.Adicionar(funcionario102_1);
            departamento02.Adicionar(funcionario102_2);
            departamento02.Adicionar(funcionario102_3);

            organizacao.GetHoraTrabalhada();
            
        }
    }
}
