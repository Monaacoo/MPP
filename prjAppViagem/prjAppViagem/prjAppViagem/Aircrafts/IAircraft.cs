using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAppViagem.Aircrafts
{
    interface IAircraft
    {
        void StartRoute();
        void GetCargo();
        void CheckWind();
    }
}
