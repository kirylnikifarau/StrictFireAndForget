using System;
using System.Threading.Tasks;

namespace StrictFireAndForget
{
    public class FireAndForgetClass
    {
        public async Task FireAndForgetMethodAsync()
        {
            Console.WriteLine("Method started");
            await Task.Delay(5000);
            Console.WriteLine("Method finished");
        }
    }
}
