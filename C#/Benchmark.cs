using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace QuerySamples
{
    class Benchmark
    {
       public static double getTimeOf(Func<IEnumerable<object>> func)
        {
            Stopwatch watch = Stopwatch.StartNew();

            func.Invoke().Count();

            watch.Stop();
            return watch.Elapsed.TotalMilliseconds;
        }
    }
}
