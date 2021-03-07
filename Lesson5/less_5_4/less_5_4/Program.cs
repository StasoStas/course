using System;
using System.IO;

namespace less_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Intel\Desktop\LabMoscow\Lesson5\less_5_4");
            FileSystemInfo[] directories = di.GetFileSystemInfos();

            foreach (var item in directories)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
