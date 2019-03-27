using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingEnergyLoss.Materials
{
    public class MaterialRepository : IMaterial
    {
        private List<Material> _defaultMaterial = new List<Material>()
            {
                new Material(){ID = 1, Name = "Ytong", Lambda = 0.09},
                new Material(){ID = 2,Name = "Omietka", Lambda = 0.15},
                new Material(){ID = 3,Name = "Beton", Lambda = 1.3},
                new Material(){ID = 4,Name = "Grafitovy polystyren", Lambda = 0.31}
            };



        public List<Material> GetMaterials()
        {
            return _defaultMaterial;            
        }
               
        public Material CreateMaterial(int id,double width)
        {
            Material ret = null;
            foreach(Material material in _defaultMaterial)
            {
                if (id == material.ID)
                {
                    ret = new Material()
                    {
                        ID = id,
                        Name = material.Name,
                        Lambda = material.Lambda,
                        Thickness = width
                    };
                    break;
                }
            }
            return ret;
        }
    }
}
