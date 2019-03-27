using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingEnergyLoss.Materials;

namespace BuildingEnergyLoss
{
    class Wall:Construction
    {
        public double Height { get; set; }
        public Wall(string name, double width, double lenght, List<Material> materials,double height) : base(name, width, lenght, materials)
        {
            Name = name;
            Width = width;
            Lenght = lenght;
            this.materials = materials;
            Height = height;
            Area = GetArea();
        }

        public override double GetArea()
        {
            double value = 2 * (Lenght * Height) + 2 * (Width * Height);
            return value;
        }
    }
}
