using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterFromServer
{
    internal static class Server
    {
        private static readonly object locker = new object();
        private static int _counter = 0;

        public static int GetCount()
        {
            return _counter;
        }
        public static async Task<int> AddToCount(int value = 1)
        {
            lock (locker)
            {
                _counter += value;
            }
            return _counter;
        }
    }
}
