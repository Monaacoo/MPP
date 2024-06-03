using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCafe
{
    public class Cafe : IBebida
    {
        public string GetDescricao()
        {
            return "Cafe";
        }
        public double Custo()
        {
            return 2.00;
        }
    }
}
