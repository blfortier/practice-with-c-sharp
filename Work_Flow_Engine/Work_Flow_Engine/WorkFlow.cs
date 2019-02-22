using System.Collections.Generic;

namespace Work_Flow_Engine
{
    public class WorkFlow : IWorkFlow
    {
        private readonly List<IActivities> _activities;

        public WorkFlow()
        {
            _activities = new List<IActivities>();
        }

        public void Add(IActivities activity)
        {
            _activities.Add(activity);
        }

        public void Delete(IActivities activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivities> DisplayActivities() 
        {
            return _activities;
        }
    }
}