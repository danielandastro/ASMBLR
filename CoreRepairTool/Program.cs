using System;
using System.Net;

namespace CoreRepairTool
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var client = new WebClient();
                client.DownloadFile("https://github.com/danielandastro/ASMBLR/blob/update-branch/stnd.dll?raw=true", "ASMBLR.dll");
            }
            catch(Exception){Console.WriteLine("Connection Failed");}
        }
    }
}