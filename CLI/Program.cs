using System;
using ASMBLR;
namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new Interpreter();
            while (true)
            {
                Console.Write(">");
                var hold = Console.ReadLine();
                interpreter.Runner(hold);
            }
        }
    }
}