using SaladMaker.IngredientOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladMaker
{
    public class ChickenSaladExtraRanch : Salad
    {
        public override void CreateSalad()
        {
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new GrilledChicken());
            Ingredients.Add(new Tomato());
            Ingredients.Add(new RedOnion());
            Ingredients.Add(new RanchDressing());
            Ingredients.Add(new RanchDressing());
            Ingredients.Add(new Croutons());
        }
    }
}
