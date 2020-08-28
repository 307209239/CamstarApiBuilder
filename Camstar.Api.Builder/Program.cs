using System;

namespace Camstar.Api.Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("");
            new Runner().Generate();
            Console.ReadKey();
        }
    }
}