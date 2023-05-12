using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp.Classes
{
    public abstract class Bird
    {
        protected string name;
        protected string size;
        protected string beakType;
        protected string plumage;
        protected string feetType;

        public abstract void SetLocation(double longitude, double latitude);

        public abstract void Draw();

    }
}
