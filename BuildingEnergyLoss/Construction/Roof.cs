using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingEnergyLoss.Materials;

namespace BuildingEnergyLoss
{
    class Roof:Construction
    {
        public Roof(string name, double width, double lenght, List<Material> materials) : base(name, width, lenght, materials)
        {
            Name = name;
            Width = width;
            Lenght = lenght;
            this.materials = materials;            
            Area = GetArea();
        }

       


    }
}
