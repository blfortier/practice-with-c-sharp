using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // Customer at the restaurant
    public class Customer
    {
        private string _name;

        public Customer(string name)
        {
            this._name = name;
        }

        public string Name { get { return _name; } }
    }
}
