using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string workingDirectory = "C:\\Users\\Shraddha Choudhary\\eclipse\\java-2021-12";
            SubDirectory subDirectory = new SubDirectory();
            subDirectory.getSubDirectories(workingDirectory);
        }
    }
}
