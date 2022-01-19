using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowExerciseProblem
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow workFlow = new WorkFlow();
            workFlow.Add(new VideoUploader());
            workFlow.Add(new SendMail());
            workFlow.Add(new CallWebService());
            workFlow.Add(new ChangeVideoRecordStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);
            Console.ReadLine();

        }
    }
}
