using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class AsyncCall
    {
        static readonly CancellationTokenSource cancellationToken = new();
        private int _timeout = 5000;

        public async Task<bool> AsyncCaller(int timeout = 5000)
        {
            _timeout = timeout;
            Random r = new();

            cancellationToken.CancelAfter(_timeout);
            await Task.Delay(r.Next(1, 10000));
            var result = cancellationToken.IsCancellationRequested;
            
            cancellationToken.Dispose();
            
            Console.WriteLine(!result);
            return !result;
        }
    }
}
