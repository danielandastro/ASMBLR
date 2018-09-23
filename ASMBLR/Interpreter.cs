using System;
using System.Collections.Generic;
namespace ASMBLR
{
    public class Interpreter
    {
        public const string ver = "0.2";
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
                    catch (Exception )
                    {
                        Strings[args] = dest;
                    }
                    break;
                case "pt":
                    try
                    {
                        output=Ints[args].ToString();
                    }
                    catch (Exception )
                    {
                        try {output=Strings[args];}
                        catch (Exception)
                        {
                            output = "Error: Variable "+args+" may not be initialised correctly";
                        }
                    }
                    break;
                case "ad":
                    try{Ints[args] += Ints[dest];}
                    catch (Exception)
                    {
                        output = "Error: Variable "+args+" or "+dest+" may not be initialised correctly";
                    }
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
                    try{Ints[args] =Ints[args] *  Ints[dest];}
                    catch (Exception)
                    {
                        output = "Error: Variable "+args+" or "+dest+" may not be initialised correctly";
                    }
                    break;
                case "dv":
                    try
                    {
                        Ints[args] = Ints[args] / Ints[dest];
                    }
                    catch (Exception)
                    {
                        output = "Error: Variable "+args+" or "+dest+" may not be initialised correctly";
                    }
                    break;
                case "sb":
                    try{Ints[args] =Ints[args] -  Ints[dest];}
                    catch (Exception)
                    {
                        output = "Error: Variable "+args+" or "+dest+" may not be initialised correctly";
                    }
                    break;
                    default:
                        Console.WriteLine("Error: "+spaceSplit[0]+" is not a recognised command");
                        break;
            }

            return output;


        }
    }
}