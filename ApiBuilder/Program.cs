using System;

namespace ApiBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Generation has started...");
            Runner runner = new Runner();
            runner.Init();
            Console.Write("Generation has finished with:\n" + (object) runner.Generate() + "\n");
            Console.ReadKey();
        }
    }
}
