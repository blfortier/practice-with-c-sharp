using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // ConcreteFactory - implements the abstract factory's methods

    public class AdultFurnitureFactory : FurnitureFactory 
    {
        public override Bed BuildBed()
        {
            return new KingBed();
        }

        public override Dresser BuildDresser()
        {
            return new ExtraLargeDresser();
        }
    }
}
