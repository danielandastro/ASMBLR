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
            PreFlightChecks();


            while (true)
            {
                Console.Write(">");
                var hold = Console.ReadLine();
                hold =interpreter.Runner(hold);
                Console.WriteLine(hold);
            }
        }

        private static void PreFlightChecks()
        {
            var client = new WebClient();
            var newVer = "";
            try
            {
                newVer = client.DownloadString(
                    "https://raw.githubusercontent.com/danielandastro/ASMBLR/update-branch/update.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Connection Failed");
            }

            if (!newVer.Contains(Interpreter.ver))
            {
                Console.WriteLine("Update Available " + newVer + "Show ChangeLog");
                if (Console.ReadLine().Equals("y"))
                {
                    
                    try
                    {
                        Console.WriteLine(client.DownloadString("https://raw.githubusercontent.com/danielandastro/ASMBLR/update-branch/chnglg.txt"));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Connection Failed");
                    }

                    Console.WriteLine("Update(y/n)");
                    if (Console.ReadLine().Equals("y"))
                    {
                        try
                        {
                            client.DownloadFile("https://github.com/danielandastro/ASMBLR/blob/update-branch/core.dll?raw=true",
                                "ASMBLR.dll");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Connection Failed");
                        }
                        Console.WriteLine("ASMBLR Core CLI, using ASMBLR version "+Interpreter.ver);
                    }
                }
            }
        }
    }
}