using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment smallAp = new SmallApartment();
            Person Mypers = new Person();
  
            //Mypers.House1 = smallAp;
            Mypers.ShowData();
            Console.Read();
        }
    }
}
