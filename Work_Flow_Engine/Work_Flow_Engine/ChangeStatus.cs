using System;

namespace Work_Flow_Engine
{
    class ChangeStatus : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Status is changed...");
        }
    }
}