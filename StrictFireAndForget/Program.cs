using StrictFireAndForget;
using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var fireAndForget = new FireAndForgetClass();

        Console.WriteLine("Main started");
        fireAndForget.FireAndForgetMethod();
        Console.WriteLine("Main finished");
    }
}
