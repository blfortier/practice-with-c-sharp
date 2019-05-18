using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // Each section of the kitchen
    // must implement this interface
    public interface KitchenSection
    {
        FoodItem PrepDish(int DishId);
    }
}
