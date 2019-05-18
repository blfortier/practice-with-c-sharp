using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HotPrep : KitchenSection
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
