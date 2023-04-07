namespace PatternMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();
            Director director = new Director();

            Controller controller = new Controller(developer, director);

            director.GiveCommand("Работать");


            Console.WriteLine();

        }
    }
}

