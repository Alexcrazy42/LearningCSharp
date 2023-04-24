using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Counter
    {

        public delegate Task CounterDelegate();

        public event CounterDelegate onCount;

        public async Task Count()
        {

            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    
                    if (i == 11)
                    {
                        onCount(); // call event
                    }
                    Console.Write("#");
                    Thread.Sleep(5);
                }
            });
        }
    }
}
