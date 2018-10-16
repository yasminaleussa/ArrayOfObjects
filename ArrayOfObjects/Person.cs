using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    class Person 
    {
        protected string name;
        protected House house;

        public Person()
        {
            name = "Yas";
            house = new House(500);
        }

        public Person(string pers)
        {
            this.name = pers;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public House House1

        {
            set { house = value; }
            get { return house; }
        }

        public void ShowData()
        {
            Console.WriteLine("My name is " + name);
     
            house.ShowData();
            house.Door1.ShowData();
        }
    }
}
