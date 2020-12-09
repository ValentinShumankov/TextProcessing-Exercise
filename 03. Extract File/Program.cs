using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string [ ] args)
        {
            List<string> location = Console.ReadLine().Split(@"\",StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] fileName = location[location.Count-1].Split(".").ToArray();
            Console.WriteLine("File name: "+ fileName[0] + Environment.NewLine +"File extension: " + fileName[1] );
        }
    }
}
