using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    class Door 
    {
        protected string _color;

        public Door()
        {
            _color = "brown";
        }

        public Door(string color)
        {
            this._color = color;
        }

        public string Color
        {
            set { _color = value; }
            get { return _color; }
        }

        
        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is " + _color);
        }
    }
}
