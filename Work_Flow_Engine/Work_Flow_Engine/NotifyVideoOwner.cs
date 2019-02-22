using System;

namespace Work_Flow_Engine
{
    class NotifyVideoOwner : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("You video has begun processing");
        }
    }
}