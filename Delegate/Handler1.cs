

namespace Delegate
{
    public class Handler1
    {

        static public async Task ShowMessage()
        {
            
            Console.WriteLine("\nLet's start from Handler1, there are already 11");
            
            await Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(5);
                };
            });
        }

    }
}
