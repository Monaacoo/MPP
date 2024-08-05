using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjComposite
{
    public class Edificio : Component
    {
        private List<Component> itens = new List<Component>();
        public Edificio(string nome) : base(nome) { }

        public override void Exibir()
        {
            Console.WriteLine($"Edificio: {nome}");

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
