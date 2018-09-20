using System;
using ASMBLR;
using System.Net;
namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASMBLR Core CLI, using ASMBLR version "+Interpreter.ver);
            var interpreter = new Interpreter();
            Console.WriteLine("Update/Repair (y, n)");
            if(Console.ReadLine().Equals("y")){using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/danielandastro/ASMBLR/blob/update-branch/core.dll?raw=true", "ASMBLR.dll");
            }}
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