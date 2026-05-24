using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopstopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();
            stopwatch.Start();
            System.Threading.Thread.Sleep(1000);
            stopwatch.Stop();
            Console.WriteLine("Duration:" + stopwatch.GetDuration());

            stopwatch.Start();
            System.Threading.Thread.Sleep(1000);
            stopwatch.Stop();
            Console.WriteLine("Duration:" + stopwatch.GetDuration());

        }
    }
    class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            
                throw new InvalidOperationException("Stopwatch is still running.");
                _startTime = DateTime.Now;
                _isRunning = true;
            
        }
        public void Stop()
        {
            if (!_isRunning)
            
                throw new InvalidOperationException("Stopwatch is not running.");
                _stopTime = DateTime.Now;
                _isRunning = false;
            
        }
        public TimeSpan GetDuration()
        {
            if ( _isRunning)
            
                throw new InvalidOperationException("Stopwatch is still running.");
                return _stopTime - _startTime;
            
        }
    }
}
