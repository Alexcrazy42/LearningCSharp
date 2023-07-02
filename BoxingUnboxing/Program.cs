Print(1);

Print(new A(1));






void Print(object a)
{
    Console.WriteLine(a);
}

public class A
{
    public int id;
    public A(int id)
    {
        this.id = id;
    }

}







