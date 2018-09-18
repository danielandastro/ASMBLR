﻿using System;
using ASMBLR;
namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASMBLR Core CLI, using ASMBLR version "+Interpreter.ver);
            var interpreter = new Interpreter();
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