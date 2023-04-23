List<Task> list = new List<Task>();
list.Add(Print1());
list.Add(Print2());
list.Add(Print3());


foreach (Task t in list)
{
    t.GetAwaiter().GetResult();
    t.Wait();
};


async Task Print1()
{
    Console.WriteLine($"start1 in [{Thread.CurrentThread.ManagedThreadId}]");
    await Task.Run(async () =>
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write("#");
            await Task.Delay(100);
        }
        Console.WriteLine();
        
    });

    
    Console.WriteLine($"end1 complete in [{Thread.CurrentThread.ManagedThreadId}]");

}

async Task Print2()
{
    Console.WriteLine($"start2 in [{Thread.CurrentThread.ManagedThreadId}]");
    await Task.Run(() =>
    {
        for (int i = 0; i < 50; i++)
        {
            Console.Write("*");
            Thread.Sleep(100);
        }
        Console.WriteLine();

    });
    Console.WriteLine($"in2 complete in [{Thread.CurrentThread.ManagedThreadId}]");
}


async Task Print3()
{
    Console.WriteLine($"start3 in [{Thread.CurrentThread.ManagedThreadId}]");
    await Task.Run(() =>
    {
        for (int i = 0; i < 40; i++)
        {
            Console.Write("@");
            Thread.Sleep(100);
        }
        Console.WriteLine();

    });
    Console.WriteLine($"in3 complete in [{Thread.CurrentThread.ManagedThreadId}]");
}