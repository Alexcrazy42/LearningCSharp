using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Handler2
    {
        static public async Task ShowMessage()
        {

            Console.WriteLine("\nLet's start from Handler2, there are already 11");

            await Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("&");
                    Thread.Sleep(5);
                };
            });
        }
    }
}
