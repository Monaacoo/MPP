using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBebida cafe = new Cafe();
            Console.WriteLine($"{cafe.GetDescricao()} - R${cafe.Custo():F2}");

            // Adicionando leite 
            cafe = new LeiteDecorator(cafe);
            Console.WriteLine($"{cafe.GetDescricao()} - R${cafe.Custo():F2}");

            // Adicionando açúcar 
            cafe = new AcucarDecorator(cafe);
            Console.WriteLine($"{cafe.GetDescricao()} - R${cafe.Custo():F2}");

            // Adicionando chocolate 
            cafe = new ChocolateDecorator(cafe);
            Console.WriteLine($"{cafe.GetDescricao()} - R${cafe.Custo():F2}");

        }
    }
}
