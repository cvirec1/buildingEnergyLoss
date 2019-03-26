using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingEnergyLoss
{
    public interface IMaterial
    {
        double Lambda{ get; set; }
        double Thickness { get; set;}        
        double GetR(double x, double y);
        double TermoResistance { get; set; }
    }
}
