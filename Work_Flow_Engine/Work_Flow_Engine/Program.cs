using System;
using System.Linq;
using System.Text;

namespace Work_Flow_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            workFlow.Add(new UploadVideo());
            workFlow.Add(new CallWebService());
            workFlow.Add(new NotifyVideoOwner());
            workFlow.Add(new ChangeStatus());

            var workFlowEngine = new WorkFLowEngine();
            workFlowEngine.Run(workFlow);

            Console.WriteLine();
        }
    }
}
