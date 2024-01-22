using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerchioCasa
{
    internal class Cerchio
    {
        public double Raggio { get; set; }

        public Cerchio()
        {

        }

        public double Calcolap()
        {
            return 2 * Math.PI * Raggio;
        }

        public double Calcolaa()
        {
            return Raggio * Raggio * Math.PI;
        }
    }
}
