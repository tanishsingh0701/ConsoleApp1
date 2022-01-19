using System;

namespace ClassesAndObjects
{
    public class Stopwatch
    {
        private int duration;
        bool _isStart = false;
        bool isStop = false;
        private DateTime start_time;
        private DateTime stop_time;

        public void Start()
        {
            if (_isStart)
                throw new InvalidOperationException("Already Start");
            start_time = DateTime.Now;
            _isStart = true;

        }

        public void Stop()
        {
            _isStart = false;
            stop_time = DateTime.Now;
            isStop = true;

        }

        public TimeSpan GetDuration()
        {
            return (stop_time - start_time);
        }
    }
}
