using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // This class is the Facade of the program. It hides
    // the complexity of the KitchenSection classes.
    public class Server
    {
        private ColdPrep _coldPrep = new ColdPrep();
        private HotPrep _hotPrep = new HotPrep();
        private Bar _bar = new Bar();

        public Order PlaceOrder(Customer customer,
                                    int coldAppId,
                                    int hotEntreeId,
                                    int drinkId)
        {
            Console.WriteLine("{0} places order for cold app #"
                                    + coldAppId.ToString()
                                    + ", hot entree #" + hotEntreeId.ToString()
                                    + ", and drink #" + drinkId.ToString(), customer.Name);

            Order order = new Order();
            order.Appetizer = _coldPrep.PrepDish(coldAppId);
            order.Entree = _hotPrep.PrepDish(hotEntreeId);
            order.Drink = _bar.PrepDish(drinkId);

            return order;
        }
    }
}
