List<Task> list = new List<Task>();
list.Add(Print1());
list.Add(Print2());
list.Add(Print3());


foreach (Task t in list)
{
    t.ContinueWith(t => { });
    t.Wait();
}


async Task Print1()
{
    Console.WriteLine("start1");
    await Task.Run(() =>
    {
        Thread.Sleep(2000); // imitation of long work (with DB e.g.)
        Console.WriteLine("in1 complete");
    });
}

async Task Print2()
{
    Console.WriteLine("start2");
    await Task.Run(() =>
    {
        Thread.Sleep(6000); // imitation of long work (with DB e.g.)
        Console.WriteLine("in2 complete");
    });
}


async Task Print3()
{
    Console.WriteLine("start3");
    await Task.Run(() =>
    {
        Thread.Sleep(3000); // imitation of long work (with DB e.g.)
        Console.WriteLine("in3 complete");
    });
}