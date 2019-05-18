using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // A section of the kitchen
    public class Bar : KitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            return new FoodItem()
            {
                DishId = dishId
            };
        }
    }
}
