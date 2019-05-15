using SaladMaker.IngredientOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladMaker
{
    public class DeluxeSalad : Salad
    {
        public override void CreateSalad()
        {
            Ingredients.Add(new SpringMix());
            Ingredients.Add(new Steak());
            Ingredients.Add(new Steak());
            Ingredients.Add(new Tomato());
            Ingredients.Add(new RedOnion());
            Ingredients.Add(new Carrots());
            Ingredients.Add(new Mushroom());
            Ingredients.Add(new Egg());
            Ingredients.Add(new Broccoli());
            Ingredients.Add(new Croutons());
            Ingredients.Add(new ThousandIslandDressing());
        }
    }
}
