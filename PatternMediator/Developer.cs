
using PatternMediator;

class Developer : Employee
{
    private bool isWorking;

    public Developer(IMediator mediator = null)
        : base(mediator) { }

    public void ExecuteWork()
    {
        Console.WriteLine("<-Девелопер в работе");
        mediator.Notify(this, "<-Девелопер проектирует");
    }

    public void SetWork(bool state)
    {
        isWorking = state;
        if (!state)
        {
            Console.WriteLine("<-Девелопер освобожден от работы");
        }
        else
        {
            Console.WriteLine("<-Девелопер начал работать");
        }

    }
}
