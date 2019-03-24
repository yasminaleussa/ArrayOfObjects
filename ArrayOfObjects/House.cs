using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    class House 
    {
        protected float _area;
        protected Door door;

        
        public  House(float x)
        {
            this._area= x;
            door = new Door();
        }

        public float Area
        {
            set { _area = value; }
            get { return _area; }
        }

        public Door Door1

        {
            set { door = value; }
            get { return door; }
        }
        public virtual void ShowData()
        {
            Console.WriteLine( "I am a house and my area is " + _area + "m2...");
        }






    }
}
