using System;

namespace StopWatchExercise
{
    public class StopWatch 
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private bool _running;

        public void Start() 
        {
            if(_running)
               throw new InvalidOperationException("StopWatch is Already running");
            _startTime = DateTime.Now;
            _running = true;
            
        }

        public void Stop() 
        {
            if(!_running)
                throw new InvalidOperationException("StopWatch is Not running");
            _endTime = DateTime.Now;
            _running = false;
            
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }

    }
}
