/*
struct - value type
work faster than class because places in stack
struct need to use for create small object, for example struct Point (x, y, z)

class - reference type 
work slowly than struct because places in heap 
class need to use for create big object, for example class User in someone big system
*/


using ClassVsStruct;

Point point = new Point(1, 2, 3); // may use struct without constuctor
Console.WriteLine(point.X); // if we don't use constructor => 0 because 0 is default value when creating a int type

User user = new User(1, "alex"); // if we use constructor in class we can't create instance of class if we don't use overload 
Console.WriteLine(user.Nickname); // alex 

Car car = new Car(); // create an instance of class inherited of absract class AbstractClass 
car.ShowInfo(); // method ShowInfo we redefine

IDataProcessor dataProcessor = new ConsoleDataProcessor();

dataProcessor.ProcessData(new DbDataProvider());
dataProcessor.ProcessData(new FileDataProvider());
dataProcessor.ProcessData(new ApiDataProvider());




// class inherited of absract class AbstractClass
class Car : AbstractClass
{
    public override void ShowInfo()
    {
        Console.WriteLine(GetType().Name);
    }
}

class DbDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from Db";
    }
}


class FileDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from file";
    }
}

class ApiDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from Api";
    }
}

class ConsoleDataProcessor : IDataProcessor
{
    public void ProcessData(IDataProvider dataProvider)
    {
        Console.WriteLine(dataProvider.GetData());
    }
}

struct Point
{
    public int X;
    public int Y;
    public int Z;

    public Point(int x, int y, int z)
    {
        X = x; Y = y; Z = z; 
    }
}

class User
{
    public int UserId;
    public string Nickname;

    public User(int userId, string nickname)
    {
        UserId = userId;
        Nickname = nickname;
    }
}