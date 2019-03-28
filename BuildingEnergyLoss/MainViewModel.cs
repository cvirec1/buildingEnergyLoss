using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingEnergyLoss.Materials;

namespace BuildingEnergyLoss
{
    public class MainViewModel
    {
        public List<int> RoofId { get; set; }
        public List<double> RoofThickness { get; set; }
        public List<int> FloorId { get; set; }
        public List<double> FloorThickness { get; set; }
        public List<int> WallId { get; set; }
        public List<double> WallThickness { get; set; }
        public List<string> HouseID { get; set; }
        public CountryType Country { get; set; }
        public BuildingType BuildType { get; set; }
        private MaterialRepository _materials;        
        public double WallWidth { get; set; }
        public double WallLenght { get; set; }
        public double WallHeight { get; set; }
        public double FloorWidth { get; set; }
        public double FloorLenght { get; set; }
        public double RoofWidth { get; set; }
        public double RoofLenght { get; set; }
        public int MinTemperature { get; set; }
        public int InsideTemperature { get; set; }
        //public List<double> MeasureWall { get; set; }
        //public List<double> MeasureFloor { get; set; }
        //public List<double> MeasureRoof { get; set; }
        public MainViewModel()
        {
            HouseID = new List<string>();
            RoofId = new List<int>();
            RoofThickness = new List<double>();
            FloorId = new List<int>();
            FloorThickness = new List<double>();
            WallId = new List<int>();
            WallThickness = new List<double>();
            _materials = new MaterialRepository();
        }

        public List<Material> GetMaterial()
        {
            return _materials.GetMaterials();
        }

        public Building CreateBuilding()
        {
            List<Construction> constructions = new List<Construction>();

            Building newBuilding = new Building(HouseID[0], new Author(HouseID[1], HouseID[2]), Country, BuildType, MinTemperature, InsideTemperature, constructions,GetWallValue(),GetFloorValue(),GetRoofValue());
            return newBuilding;
        }

        public double GetWallValue()
        {
            List<Material> materialWall = new List<Material>();
            for (int i = 0; i < WallId.Count; i++)
            {                
                materialWall.Add(_materials.CreateMaterial(WallId[i], WallThickness[i]));
            }            
            Wall newWall = new Wall("Wall",WallWidth,WallLenght,materialWall,WallHeight);
            double value = newWall.GetConstructionU() * newWall.GetArea() * (InsideTemperature - MinTemperature);
            return value;
        }
        public double GetFloorValue()
        {
            List<Material> materialFloor = new List<Material>();
            for (int i = 0; i < FloorId.Count; i++)
            {
                materialFloor.Add(_materials.CreateMaterial(WallId[i], WallThickness[i]));
            }
            Floor newWall = new Floor("Floor", WallWidth, WallLenght, materialFloor);
            double value = newWall.GetConstructionU() * newWall.GetArea() * (InsideTemperature - MinTemperature);
            return value;
            //List<Material> materialFloor = new List<Material>();
            //materialFloor = null;
            //foreach (Material m in GetMaterial())
            //{
            //    for (int i = 0; i < WallId.Count(); i++)
            //    {
            //        if (m.ID == WallId[i])
            //        {
            //            m.Thickness = WallThickness[i];
            //            materialFloor.Add(m);
            //        }
            //    }

            //}
            //Floor newFloor = new Floor("Floor", FloorWidth, WallLenght, materialFloor);
            //return newFloor.GetConstructionU();
        }
        public double GetRoofValue()
        {
            List<Material> materialRoof = new List<Material>();
            for (int i = 0; i < FloorId.Count; i++)
            {
                materialRoof.Add(_materials.CreateMaterial(WallId[i], WallThickness[i]));
            }
            Roof newWall = new Roof("Roof", WallWidth, WallLenght, materialRoof);
            double value = newWall.GetConstructionU() * newWall.GetArea() * (InsideTemperature - MinTemperature);
            return value;
            //List<Material> materialRoof = new List<Material>();
            //materialRoof = null;
            //foreach (Material m in GetMaterial())
            //{
            //    for (int i = 0; i < WallId.Count(); i++)
            //    {
            //        if (m.ID == WallId[i])
            //        {
            //            m.Thickness = WallThickness[i];
            //            materialRoof.Add(m);
            //        }
            //    }

            //}
            //Roof newRoof = new Roof("Floor", FloorWidth, WallLenght, materialRoof);
            //return newRoof.GetConstructionU();
        }
    }
}
