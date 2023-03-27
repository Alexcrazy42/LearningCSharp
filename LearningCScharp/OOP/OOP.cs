
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Имя", 19);
        student.Klass = 11;
        Person person = student;
        Console.Write(person.Name);
    }
}

class Person
{
    private string name;
    public int age;

    public string Name
    {
        get { return name; }
        set
        {
            if (value != null)
            {
                name = value;
            }
            else
            {
                throw new Exception();
            }
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                throw new Exception("Число должно быть больше 0");
            }
        }
    }

    public Person()
    {
        throw new Exception("Нельзя пустым объявить");
    }

    //public person(string name, int age)
    //{
    //    this.name = name;
    //    this.age = age;
    //}

}

class Student : Person
{
    private int klass;
    public int Klass
    {
        get { return klass; }
        set
        {
            if (value >= 1 && value <= 11)
            {
                klass = value;
            }
            else throw new Exception("Класс должен быть от 1 до 11");
        }
    }

    public Student(string name, int age) 
        : base(name, age)
    {
        this.Name = name;
        this.Age = age;
    }
}