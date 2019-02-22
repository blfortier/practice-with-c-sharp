namespace Work_Flow_Engine
{
    public class WorkFLowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (IActivities activity in workFlow.DisplayActivities())
            {
                activity.Execute();
            }
        }
    }
}