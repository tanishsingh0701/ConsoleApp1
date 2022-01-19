using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            for (var i = 0; i < 2; i++) 
            {
                stopWatch.Start();
                Thread.Sleep(1000);
                stopWatch.Stop();

                Console.WriteLine("Duration: "+stopWatch.GetInterval());
                Console.WriteLine("Please enter to run stopwatch one more time");
                Console.ReadLine();
            }
        }
    }
}
