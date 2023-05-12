using BirdsFlyingAroundApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp.Classes
{
    public class BlackBird : Bird, IFly
    {
        private string _name;
        private string _size;
        private string _beakType;
        private string _plumage;
        private string _feetType;
        

        public string name
        {
            get { return _name; }
        }
        public string size
        {
            get { return _size; }
            set { _size = value; }
        }

        public string beakType
        {
            get { return _beakType; }
                set { _beakType = value; }
        }

        public string plumage
        {
            get { return _plumage; }
            set { _plumage = value; }
        }

        public string feetType
        {
            get { return _feetType; }
            set { _feetType = value; }
        }
       

        public BlackBird(string name, string size, string beakType, string plumage, string feetType)
        {
            _name = name;
            this.size = size;
            this.beakType = beakType;
            this.plumage = plumage;
            this.feetType = feetType; 
            
        }
        public override void SetLocation(double longitude, double latitude)
        {
            //set startpoint
        }

        public void SetAltitude(double altitude)
        {
            //how high 
        }

        public override void Draw()
        {
            //draw the route
        }
    }
}
