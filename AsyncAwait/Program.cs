Print();

async void Print()
{
    Console.WriteLine("start");
    await Task.Run(() =>
    {
        Task.Delay(100);
        Console.WriteLine("in");
    });
    Console.WriteLine("end");
    

}
