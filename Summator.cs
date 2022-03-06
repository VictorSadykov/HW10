using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Summator : ISum
    {
        public Summator(ILogger logger)
        {
            Logger = logger;
        }
        public ILogger Logger { get; }
        public int Sum(int a, int b) => a + b;
    }
}
