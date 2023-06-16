int[] a = new int[5];


async Task A(int index, int pause)
{
    Console.WriteLine($"start A in [{Thread.CurrentThread.ManagedThreadId}]");
    await Task.Run(() =>
    {
        Thread.Sleep(pause);
        Console.WriteLine($"inner A in thread [{Thread.CurrentThread.ManagedThreadId}]");
        a[index] = new Random().Next() % 100;
    });

    Console.WriteLine($"end A complete in [{Thread.CurrentThread.ManagedThreadId}]");
}


List<Task> tasks = new List<Task>();
tasks.Add(A(0, 300));
tasks.Add(A(1, 400));
tasks.Add(A(3, 100));

foreach(var task in tasks)
{
    task.GetAwaiter().GetResult();
    task.Wait();
}

foreach(int i in a)
{
    Console.Write(i.ToString() + " ");
}
