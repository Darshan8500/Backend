using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Session5
{
    public class FileD
    {
        public static void Run()
        {
            Console.WriteLine("7. File Handling:");
            string path = "demo.txt";
            File.WriteAllText(path, "Welcome to C# File Handling!");
            string content = File.ReadAllText(path);
            Console.WriteLine($"File Content: {content}\n");
        }
    }
}

