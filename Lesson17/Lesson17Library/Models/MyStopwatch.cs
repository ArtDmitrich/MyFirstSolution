using System.Diagnostics;

namespace Lesson17Library.Models
{
    public class MyStopwatch
    {
        private Stopwatch stopwatch;
        public MyStopwatch()
        {
            stopwatch = new Stopwatch();
        }
        public int GetOperationTime(Action operation)
        {            
            stopwatch.Start();
            operation.Invoke();
            stopwatch.Stop();
            var ts = stopwatch.Elapsed;
            stopwatch.Reset();
            return ts.Milliseconds;
        }
    }
}
