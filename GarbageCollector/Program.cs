using System;


class Program
{
    static void Main(string[] args)
    {
        Person? tim = new Person(12);
        tim.Dispose();
        Console.WriteLine(tim.age);
    }

}



class Person : IDisposable
{

    public int age;
    private bool disposed = false;

    public Person(int age)
    {
        this.age = age;
        Console.WriteLine("Constructor called");
    }


    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if(disposed == true)
        {
            return;
        }
        if(disposing == true)
        {

        }

        disposed = true;

        

    }

    ~Person()
    {
        Dispose(false);
    }


    


}