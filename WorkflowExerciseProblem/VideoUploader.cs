using System;

namespace WorkflowExerciseProblem
{
    public class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("The video is uploading");
        }
    }
}
