
class Controller : IMediator
{
    private Developer developer;
    private Director director;
    public Controller(Developer developer, Director director)
    {
        this.developer = developer;
        this.director = director;
        developer.SetMediator(this);
        director.SetMediator(this);
    }

    public void Notify(Employee emp, string msg)
    {
        if (emp is Director dir)
        {
            if (msg == "")
            {
                developer.SetWork(false);
            }
            else
            {
                developer.SetWork(true);
            }

        }
        if (emp is Developer dev)
        {
            if (msg == "<-Девелопер проектирует")
            {
                director.GiveCommand("");
            }
        }

    }
}

