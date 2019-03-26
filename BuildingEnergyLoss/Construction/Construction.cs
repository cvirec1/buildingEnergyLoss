using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingEnergyLoss
{
    public class Construction:IPlocha
    {
        public string Name { get; set; }
        public double ConstructionU { get; set; }
        public double Area { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public List<IMaterial> materials = new List<IMaterial>();
        public virtual double GetArea()
        {
            return Area = Width * Height;
        }        
        public double GetConstructionU()
        {
            double sumaR=0;
            foreach (IMaterial item in materials)
            {
                sumaR += item.GetR(item.Thickness, item.Lambda);
            }
            ConstructionU = 1 / sumaR;
            return ConstructionU;
        }
    }
}
