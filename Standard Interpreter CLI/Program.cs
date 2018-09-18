using System;
using ASMBLR;

namespace Standard_Interpreter_CLI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var interpreter = new Interpreter();
            Console.WriteLine("ASMBLR Standard CLI, using AMBLR version "+Interpreter.ver);
            while (true)
            {
                Console.Write(">");
                var hold = Console.ReadLine();
                hold =interpreter.Runner(hold);
                Console.WriteLine(hold);
            }
        }
    }
}