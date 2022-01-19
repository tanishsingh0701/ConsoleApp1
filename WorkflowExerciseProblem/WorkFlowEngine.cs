using System;

namespace WorkflowExerciseProblem
{
    public class WorkFlowEngine 
    {
        public void Run(IWorkFlow workFlow) 
        {
            foreach (ITask I in workFlow.GetTasks()) 
            {
                try 
                {
                    I.Execute();

                }
                catch (Exception) 
                {
                    throw;
                }
                
            }
        }
    
    }
}
