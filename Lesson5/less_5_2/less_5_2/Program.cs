using System;
using System.IO;

namespace less_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = $"Дата и время запуска программы: {DateTime.Now.ToString()}\n";
            string filename = "startup.txt.txt";
            File.AppendAllText(filename, date); Console.WriteLine("Hello World!");
        }
    }
}
