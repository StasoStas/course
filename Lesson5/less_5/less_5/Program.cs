using System;

namespace less_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Person.AskInfo(person);
            Person.SaveInFile(person);

            Console.WriteLine($"\nВаши данные записаны в файл InfoOfPerson.txt\n{person}");

            Console.ReadLine();
        }
    }
}
