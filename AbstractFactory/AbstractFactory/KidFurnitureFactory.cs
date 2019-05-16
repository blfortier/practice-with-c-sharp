using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    public class KidFurnitureFactory : FurnitureFactory
    {
        // ConcreteFactory
        public override Bed BuildBed()
        {
            return new BunkBed();
        }

        public override Dresser BuildDresser()
        {
            return new SmallDresser();
        }
    }
}
