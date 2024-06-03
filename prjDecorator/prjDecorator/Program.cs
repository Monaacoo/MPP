using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDecorator
{
    public class Program
    {
        /*ICarro é uma interface que define os métodos básicos.
        CarDecorator é uma classe abstrata que implementa ICarro e atua como base para todos os decoradores.
        Cada decorador (ArDecorator, TravasDecorator, VidroEletricoDecorator) herda de CarDecorator e sobrecarrega os métodos conforme necessário.
        permitindo assim adicionar funcionalidades a objetos de forma dinâmica
        */
        static void Main(string[] args)
        {
            ICarro carro = new Carro();  // log "Montando: construir chassi, adicionar peças principais"

            // Adiciona os vidros elétricos ao carro
            carro = new VidroEletricoDecorator(carro); // log "Montar: adicionar vidros elétricos"

            // Agora adiciona as travas elétricas e o ar condicionado
            carro = new TravasDecorator(carro); // log "Montar: adicionar travas elétricas"
            carro = new ArDecorator(carro); // log "Montar: adicionar unidade de ar condicionado"

            // Vamos ligar o motor e dar uma volta!
            carro.Ligar(); // log 'O motor dá partida com um rugido!' e 'O ar fresco começa a soprar.'
            carro.Dirigir(); // log 'Lá vamos nós!' e 'As portas travam automaticamente.'
        }

    }
}
