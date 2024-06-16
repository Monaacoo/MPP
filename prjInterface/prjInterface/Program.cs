using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quadrado = new Quadrado();
            var circulo = new Circulo();

            quadrado.Lado = 10;
            circulo.Raio = 10;
            Console.WriteLine(
                $"Area do quadrado: {quadrado.area()}" + "\n" +
                $"Comprimento do quadrado: {quadrado.comprimento()}" + "\n" +
                $"Area do circulo: {circulo.area()}" + "\n" +
                $"Comprimento do circulo: {circulo.comprimento()}");
        }
    }
}