using System;
using ASMBLR;
using System.Net;
namespace Standard_Interpreter_CLI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var interpreter = new Interpreter();
            Console.WriteLine("ASMBLR Standard CLI, using AMBLR version "+Interpreter.ver);
            if(Console.ReadKey().KeyChar.Equals('y')){using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/danielandastro/ASMBLR/blob/update-branch/stnd.dll?raw=true", "ASMBLR.dll");
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