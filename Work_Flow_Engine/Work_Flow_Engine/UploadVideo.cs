using System;

namespace Work_Flow_Engine
{
    class UploadVideo : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("The video has been uploaded to cloud storage...");
        }
    }
}