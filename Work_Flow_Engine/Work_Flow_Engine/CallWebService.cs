using System;

namespace Work_Flow_Engine
{
    class CallWebService : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("The web service is being called...");
        }
    }
}