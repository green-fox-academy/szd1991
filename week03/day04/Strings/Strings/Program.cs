// Given a string, compute recursively (no loops) a new string where all the
// lowercase 'x' chars have been changed to 'y' chars.

using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Sorrx I don't feel mxself verx well. Maxbe xou can do something about it?";
            Console.WriteLine(welcome);
            Console.WriteLine("Sure here you go:");
            Console.WriteLine(xToYConverter(welcome));

            Console.ReadLine();
        }

        public static string xToYConverter(string x)
        {
            if (x.StartsWith("x"))
            {
                return x.Replace("x", "y");
            }
            else
            {
                return x[0] + xToYConverter(x.Substring(1));
            }
        }
    }
}
