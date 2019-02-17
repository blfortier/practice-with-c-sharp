using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopwatchExercise
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _stop;
        private bool _isRunning;

        // Calling the Start method will start the 
        // stopwatch by calling DateTime.Now
        public void Start()
        {
            // If the stopwatch is already running,
            // throw an exception
            if (_isRunning)
            {
                throw new InvalidOperationException("The stopwatch is already running...");
            }

            _start = DateTime.Now;
            _isRunning = true;
        }

        // The Stop method calls DateTime.Now and this is
        // the stop time
        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("The stopwatch isn't running...");
            }

            _stop = DateTime.Now;
            _isRunning = false;

        }

        // The Stop method
        public TimeSpan Duration()
        {
            return _stop - _start;
        }
    }
}
