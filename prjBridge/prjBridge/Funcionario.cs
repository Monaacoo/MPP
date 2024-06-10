using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridge
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SalarioBase { get; set;}
        public decimal Incentivo { get; set; }
        public decimal SalarioTotal { get; set; }

    }
}
