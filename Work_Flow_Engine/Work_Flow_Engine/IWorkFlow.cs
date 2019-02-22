using System.Collections.Generic;

namespace Work_Flow_Engine
{
    public interface IWorkFlow
    {
        void Add(IActivities activity);
        void Delete(IActivities activity);
        IEnumerable<IActivities> DisplayActivities();
    }
}