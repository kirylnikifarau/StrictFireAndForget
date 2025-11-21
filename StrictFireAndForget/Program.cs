using StrictFireAndForget;
using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var fireAndForget = new FireAndForgetClass();

        Console.WriteLine("Main started");
        fireAndForget.FireAndForgetMethodAsync();
        //Task.Run(() => fireAndForget.FireAndForgetMethodAsync());
        Console.WriteLine("Main finished");
    }
}
