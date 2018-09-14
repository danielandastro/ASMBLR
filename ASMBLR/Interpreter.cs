using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace ASMBLR
{
    public class Interpreter
    {
        
        private static readonly Dictionary<string, string> Strings = new Dictionary<string, string>();
        private static readonly Dictionary<string, int> Ints = new Dictionary<string, int>();
        public string Runner(string command)
        {
            var spaceSplit = command.Split(' ');//breaks command by space
            var keyword = "";//reads keywords
            var args = "";//reads first arg or source
            var dest = "";//reads second arg or destination
            var output = "";
            try
            {
                args = spaceSplit[1];
                keyword = spaceSplit[0];
                dest = spaceSplit[2];
            }
            catch{/*suppressant catch required*/}

            switch (keyword)
            { case "sh":
                output = args;
                break;
                case "dc":
                    try
                    {
                        Ints [args] = int.Parse(dest);
                    }
                    catch (Exception e)
                    {
                        Strings[args] = dest;
                    }
                    break;
                case "pt":
                    try
                    {
                        output=Ints[args].ToString();
                    }
                    catch (Exception e)
                    {
                        output=Strings[args];
                    }
                    break;
                case "ad":
                    Ints[args] += Ints[dest];
                    break;
                case "mv":
                    try
                    {
                        Ints[dest] = Ints[args];
                    }
                    catch (Exception)
                    {
                        Strings[dest] = Strings[args];
                    }
                    break;
                case "ml":
                    Ints[args] =Ints[args] *  Ints[dest];
                    break;
                case "dv":
                    Ints[args] =Ints[args] /  Ints[dest];
                    break;
                case "sb":
                    Ints[args] =Ints[args] -  Ints[dest];
                    break;
            }

            return output;


        }
    }
}