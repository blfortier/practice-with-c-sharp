using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Instacart
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] order = new int[] { 200, 20, 15 };
            int[] order1 = { 300, 40, 5 };
            int[] order2 = { 600, 40, 10 };
            int[][] shoppers = new int[][] { order1, order2 };

            bool[] shouldDeliver = delivery(order, shoppers);

            foreach  (bool result in shouldDeliver)
                Console.WriteLine(result);
        }

        static bool[] delivery(int[] order, int[][] shoppers)
        {

            var takeOrder = new bool[shoppers.Length];

            int storeToCustomerDist = order[0];
            int customerReadyTime = order[1];
            int customerMaxWaitTime = order[2];
            int fufillOrder;

            int shopperDistFromStore;
            int shopperSpeed;
            int shopperTimeSpent;

            for (var i = 0; i < shoppers.Length; i++)
            {
                shopperDistFromStore = shoppers[i][0];
                shopperSpeed = shoppers[i][1];
                shopperTimeSpent = shoppers[i][2];

                fufillOrder = (storeToCustomerDist + shopperDistFromStore) / shopperSpeed + shopperTimeSpent;

                if (fufillOrder < customerReadyTime)
                    takeOrder[i] = false;
                else if (fufillOrder < customerReadyTime + customerMaxWaitTime)
                    takeOrder[i] = true;
            }

            return takeOrder;
        }

    }
}
