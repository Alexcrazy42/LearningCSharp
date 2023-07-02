/// 1 ЗАДАЧА "ГОНКА"
//ManualResetEvent[] events = new ManualResetEvent[10];

//string[] racers = {"Вася", "Леша", "Гена", "Дима", "Саша", "Андрей", "Платон", "Витя", "Глеб", "Антон" };



//for(int i = 0; i < events.Length; i++)
//{
//    events[i] = new ManualResetEvent(false);
//    Runner r = new Runner(events[i], i);
//    new Thread(new ThreadStart(r.Run)).Start();
//}

//int index = WaitHandle.WaitAny(events);
//Console.WriteLine($"*** The winner is {racers[index]} ***");




//class Runner
//{
//    static readonly object rngLock = new object();
//    static Random rng = new Random();

//    ManualResetEvent ev;

//    int id;

//    internal Runner(ManualResetEvent ev, int id)
//    {
//        this.ev = ev;
//        this.id = id;
//    }

//    internal void Run()
//    {
//        for(int i=0; i < 10; i++)
//        {
//            int sleepTime;
//            lock(rngLock)
//            {
//                sleepTime = rng.Next(2000);
//            }

//            Thread.Sleep(sleepTime);
//            Console.WriteLine($"Runner {id} at stage {i}");
//        }

//        ev.Set();
//    }

//}


// 2 ЗАДАЧА "EVENT-DRIVEN ПЕРЕНОС ИЗ ОДНОГО LIST В ДРУГОЙ"

//var eventWait = new EventWaitHandle(false, EventResetMode.ManualReset);

//var source = new List<int>
//{
//    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
//};

//var buffer = new List<int>();

//var target = new List<int>();

//void Print(List<int> list, string start)
//{
//    Console.Write(start + ": ");
//    foreach(var i in list)
//    {
//        Console.Write($"{i} ");
//    }
//    Console.WriteLine();
//}

//var readThread = new Thread(() =>
//{
//    Console.WriteLine($"Чтение работает в потоке: {Thread.CurrentThread.ManagedThreadId}");
//    while (!(source.Count == 0))
//    {
//        var item = source.FirstOrDefault();
//        buffer.Add(item);

//        eventWait.Set();

//        source.Remove(item);
//    }

//});

//var writeThread = new Thread(() =>
//{
//    Console.WriteLine($"Запись работает в потоке: {Thread.CurrentThread.ManagedThreadId}");
//    while (target.Count < 10)
//    {
//        eventWait.WaitOne();
//        if (!buffer.Any())
//        {
//            throw new Exception("Buffer is empty!");
//        }


//        target.AddRange(buffer);
//        buffer.Clear();
//    }
//});

//readThread.Start();
//writeThread.Start();

//readThread.Join();
//writeThread.Join();

//Print(source, "Сорс");
//Print(buffer, "Буффер");
//Print(target, "Цель");


