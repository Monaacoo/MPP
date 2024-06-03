using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDecorator
{
    public class VidroEletricoDecorator : CarDecorator
    {
        public VidroEletricoDecorator(ICarro car) : base(car)
        {
            Console.WriteLine("Montar: adicionar vidros eletricos");
        }
    }
}
