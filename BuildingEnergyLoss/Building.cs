using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingEnergyLoss
{
    public class Building
    {
        private string _name; 
        private Author _author;
        private CountryType _countryType;
        private BuildingType _buildingType;
        private int _minTemperature;
        private int _insideTemperature;
        private double _wallR;
        private double _floorR;
        private double _roofR;
        private List<Construction> _constructions = new List<Construction>();      


        public Building(string name, Author author, CountryType countryType, BuildingType buildingType, int minTemperature, int insideTemperature, List<Construction> constructions, double wallR, double floorR, double roofR)
        {
            _name = name;
            _author = author;
            _countryType = countryType;
            _buildingType = buildingType;
            _minTemperature = minTemperature;
            _insideTemperature = insideTemperature;
            _constructions = constructions;
            _wallR = wallR;
            _floorR = floorR;
            _roofR = roofR;            
        }     
        
      
    }
}
