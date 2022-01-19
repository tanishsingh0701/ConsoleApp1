namespace WorkflowExerciseProblem
{
    public class ChangeVideoRecordStatus : ITask
    {
        public void Execute()
        {
           System.Console.WriteLine("Changing status of video recorded in database for processing");
        }
    }
}
