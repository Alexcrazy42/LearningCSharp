using System.Collections;

IEnumerator<int> intsEnumerator = GetInts();
intsEnumerator.MoveNext();
Console.WriteLine(intsEnumerator.Current); // 1
intsEnumerator.MoveNext();
Console.WriteLine(intsEnumerator.Current); // 2
intsEnumerator.MoveNext();
Console.WriteLine(intsEnumerator.Current); // 2, because it is last yield return in body of method



IEnumerator<int> GetInts()
{
    Console.WriteLine("first");
    yield return 1;

    Console.WriteLine("second");
    yield return 2;
}
Console.WriteLine();

Console.WriteLine("------------");

Console.WriteLine("Fibonacci");

foreach(int number in GetFibonacci(34))
{
    Console.WriteLine(number);
}

IEnumerable GetFibonacci(int maxValue)
{
    int prev = 0;
    int current = 1;
    while(current < maxValue)
    {
        yield return current;
        int newCurrent = prev + current;
        prev = current;
        current = newCurrent;
    }
}