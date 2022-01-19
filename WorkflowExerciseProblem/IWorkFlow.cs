using System.Collections.Generic;

namespace WorkflowExerciseProblem
{
    public interface IWorkFlow 
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}
