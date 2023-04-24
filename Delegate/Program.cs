

namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();


            counter.onCount += Handler1.ShowMessage;
            counter.onCount += Handler2.ShowMessage;
            Task t = counter.Count();
            t.GetAwaiter().GetResult();
            t.Wait();
        }

        
    }
}


