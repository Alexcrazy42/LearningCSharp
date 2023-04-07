class Director : Employee
{
    private string text;

    public Director(IMediator mediator = null)
        : base(mediator) { }

    public void GiveCommand(string txt)
    {
        text = txt;
        if (text == "")
        {
            Console.WriteLine("->Директор знает, что девелопер работает");
        }
        else
        {
            Console.WriteLine("->Директор дал команду " + text);
        }
        mediator.Notify(this, text);
    }


}
