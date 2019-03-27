using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingEnergyLoss.Materials
{
    public class Material
    {
        public double Lambda { get; set; }        
        public string Name { get; set; }
        public int ID { get; set; }
        public double Thickness { get; set; }
        public double GetR(double x, double y)
        {
            double TermoResistance = x / y;
            return TermoResistance;
        }
    }
}
