using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingProject1
{
    internal class SubDirectory
    {
        public void getSubDirectories(String workingDirectory)
        {
            Queue directoryQueue = new Queue();
            directoryQueue.Enqueue(workingDirectory);
            while(directoryQueue.Count > 0)
            {
                String currentDirectory = directoryQueue.Dequeue().ToString();
                Console.WriteLine(currentDirectory);
                FileDiscription fileDiscription = new FileDiscription();
                fileDiscription.GetFileDescription(currentDirectory);
                string[] subDirectories = Directory.GetDirectories(currentDirectory);
                if (subDirectories.Length > 0)
                    foreach (string subDirectory in subDirectories)
                    {
                        directoryQueue.Enqueue(subDirectory);
                    }
                else
                  continue;
            }
        }
    }
}
