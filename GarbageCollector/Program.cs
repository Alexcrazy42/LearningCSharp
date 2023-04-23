using System;


class Program
{
    static void Main(string[] args)
    {
        Test();
    }

    static public void Test()
    {
        Person? tom = null;
        try
        {
            tom = new Person(19);
        }
        finally
        {
            tom?.Dispose();
        }
    }
}



class Person : IDisposable
{

    public int age;

    public Person(int age)
    {
        this.age = age;
        Console.WriteLine("Constructor called");
    }


    public void Dispose()
    {
        Console.WriteLine("Dispose person");
    }

    


}