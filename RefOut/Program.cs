int a = 5;
MinusByRef(ref a);
Console.WriteLine(a); // 4
MinusByValue(a);
Console.WriteLine(a); // still 4, because variable value in method not refers to variable a  


void MinusByRef(ref int value)
{
    value--;
}

void MinusByValue(int value)
{
    value--;
}
