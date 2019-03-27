using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingEnergyLoss.Materials;

namespace BuildingEnergyLoss
{
    public class Construction:IPlocha
    {
        public string Name { get; set; }
        public double ConstructionU { get; set; }
        public double Area { get; set; }
        public double Width { get; set; }
        public double Lenght { get; set; }

        public List<Material> materials = new List<Material>();

        public Construction(string name, double width, double lenght, List<Material> materials)
        {
            Name = name;
            Width = width;
            Lenght = lenght;
            this.materials = materials;
            Area = GetArea();
        }

        public virtual double GetArea()
        {
            return Width * Lenght;
        }

        //public double GetConstructionU()
        //{
        //    throw new NotImplementedException();
        //}
        public double GetConstructionU()
        {
            double sumaR = 0;
            foreach (Material item in materials)
            {
                sumaR += item.GetR(item.Thickness, item.Lambda);
            }
            ConstructionU = 1 / sumaR;
            return ConstructionU;
        }
    }
}
