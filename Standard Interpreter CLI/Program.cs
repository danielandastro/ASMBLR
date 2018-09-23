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
            PreFlightChecks();
            ;
            Console.WriteLine("ASMBLR Standard CLI, using ASMBLR version " + Interpreter.ver);
            Console.WriteLine("Update(y, n)");
            if (Console.ReadLine().Equals('y'))
            {
                try
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(
                            "https://github.com/danielandastro/ASMBLR/blob/update-branch/stnd.dll?raw=true",
                            "ASMBLR.dll");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Connection Failed");
                }
            }

            while (true)
            {
                Console.Write(">");
                var hold = Console.ReadLine();
                hold = interpreter.Runner(hold);
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
                        Console.WriteLine(client.DownloadString(
                            "https://raw.githubusercontent.com/danielandastro/ASMBLR/update-branch/chnglg.txt"));
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
                            client.DownloadFile(
                                "https://github.com/danielandastro/ASMBLR/blob/update-branch/core.dll?raw=true",
                                "ASMBLR.dll");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Connection Failed");
                        }

                        Console.WriteLine("ASMBLR Core CLI, using ASMBLR version " + Interpreter.ver);
                    }
                }
            }
        }
    }
}