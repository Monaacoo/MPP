using prjAdapter.Formas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAdapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IPoligono> poligonos = new List<IPoligono>();

            Quadrado quadrado = new Quadrado(4);
            poligonos.Add(quadrado);
            Triangulo triangulo = new Triangulo(7, 4);
            poligonos.Add(triangulo);
            AdaptadorHexagono adaptadorHexagono = new AdaptadorHexagono(6);
            poligonos.Add(adaptadorHexagono);

            foreach (var i in poligonos)
            {
                Console.WriteLine("Polígonos: " + i.getArea());
            }
        }
    }
}
