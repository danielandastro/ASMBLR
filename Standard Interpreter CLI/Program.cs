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
            Console.WriteLine("ASMBLR Standard CLI, using ASMBLR version "+Interpreter.ver);
            Console.WriteLine("Update/Repair (y, n)");
            if(Console.ReadLine().Equals('y')){try{using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/danielandastro/ASMBLR/blob/update-branch/stnd.dll?raw=true", "ASMBLR.dll");
            }
                    
                }
                catch(Exception){Console.WriteLine("Connection Failed");}
            }
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