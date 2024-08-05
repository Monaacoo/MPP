using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjComposite
{
    public class Apartamento : Component
    {
        private List<Component> itens = new List<Component>();
        public Apartamento(string nome) : base(nome) { }

        public override void Exibir()
        {
            Console.WriteLine($"\nApartamento: {nome}");

            foreach (var item in itens)
            {
                item.Exibir();
            }
        }
        public void Adicionar(Component component)
        {
            itens.Add(component);
        }

        public void Remover(Component component)
        {
            itens.Remove(component);
        }
    }

}
