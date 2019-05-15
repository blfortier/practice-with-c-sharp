using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladMaker
{
    public abstract class Salad
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Salad()
        {
            CreateSalad();
        }

        // Factory method
        public abstract void CreateSalad();

        public List<Ingredient> Ingredients { get { return _ingredients; } }
    }
}
