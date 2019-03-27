using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingEnergyLoss.Materials;

namespace BuildingEnergyLoss
{
    public interface IMaterial
    {        
        List<Material> GetMaterials();
    }
}
