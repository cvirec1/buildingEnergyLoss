using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingEnergyLoss.Material
{
    class Ytong:IMaterial
    {
        public double Lambda { get; set; }
        public double Thickness { get; set; }

        public double GetR(double x, double y)
        {
            double r = x / y;
            return r;
        }
    }
}
