using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingEnergyLoss
{
    class Building
    {
        private string _name; 
        private Author _author;
        private CountryType _countryType;
        private BuildingType _buildingType;
        private int _minTemperature;
        private int _insideTemperature;
        private List<Construction> _constructions = new List<Construction>();
        private Wall _wall;
        private Roof _roof;
        private Floor _floor;


        public Building(string name, Author author, CountryType countryType, BuildingType buildingType, int minTemperature, int insideTemperature, List<Construction> constructions)
        {
            _name = name;
            _author = author;
            _countryType = countryType;
            _buildingType = buildingType;
            _minTemperature = minTemperature;
            _insideTemperature = insideTemperature;
            _constructions = constructions;            
        }     
        
      
    }
}
