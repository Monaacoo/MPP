using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var edificio = new Edificio("É nóis");
            var ap101 = new Apartamento("101");
            var ap102 = new Apartamento("102");
            var ap103 = new Apartamento("103");
            var ap104 = new Apartamento("104");
            var ap201 = new Apartamento("201");
            var ap202 = new Apartamento("202");
            var ap203 = new Apartamento("203");
            var ap204 = new Apartamento("204");
            var ap301 = new Apartamento("301");
            var ap302 = new Apartamento("302");

            var morador101_1 = new Morador("Angela");
            var morador101_2 = new Morador("Marilia");
            var morador101_3 = new Morador("João");
            var morador102_1 = new Morador("Lazaro");
            var morador102_2 = new Morador("Maria");
            var morador103_1 = new Morador("Marcos");
            var morador104_1 = new Morador("Juliano");

            var morador201_1 = new Morador("Marilia");
            var morador201_2 = new Morador("Ana");
            var morador202_1 = new Morador("Beatriz");
            var morador203_1 = new Morador("Carla");
            var morador204_1 = new Morador("Daniel");

            var morador301_1 = new Morador("Suzana");
            var morador302_1 = new Morador("Elaine");

            edificio.Adicionar(ap101);
            edificio.Adicionar(ap102);
            edificio.Adicionar(ap103);
            edificio.Adicionar(ap104);
            edificio.Adicionar(ap201);
            edificio.Adicionar(ap202);
            edificio.Adicionar(ap203);
            edificio.Adicionar(ap204);
            edificio.Adicionar(ap301);
            edificio.Adicionar(ap302);

            ap101.Adicionar(morador101_1);
            ap101.Adicionar(morador101_2);
            ap101.Adicionar(morador101_3);

            ap102.Adicionar(morador102_1);
            ap102.Adicionar(morador102_2);

            ap103.Adicionar(morador103_1);
            ap104.Adicionar(morador104_1);

            ap201.Adicionar(morador201_1);
            ap201.Adicionar(morador201_2);
            ap202.Adicionar(morador202_1);

            ap203.Adicionar(morador203_1);
            ap204.Adicionar(morador204_1);
            ap301.Adicionar(morador301_1);
            ap302.Adicionar(morador302_1);

            edificio.Exibir();
        }
    }
}
