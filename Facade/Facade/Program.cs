using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            Console.WriteLine("Hi there! I'll be your server today."
                + " What's your name?");
            string name = Console.ReadLine();

            Customer customer = new Customer(name);

            Console.WriteLine("Hello {0}. What appetizer would you like (1-15):", customer.Name);
            int appId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Good choice! Which entree would you like? (1-20)");
            int entreeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Great! Lastly, what drink would you like? (1-60)");
            int drinkId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("I'll put your order in right away!");

            // This is what the facade simplifies...
            server.PlaceOrder(customer, appId, entreeId, drinkId);
        }
    }
}
