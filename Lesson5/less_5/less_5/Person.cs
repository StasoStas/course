using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace less_5
{
    class Person
    {
        private int age;
        private string msg = String.Empty;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 & value < 120)
                {
                    age = value;
                    msg = String.Empty;
                }
                else
                {
                    age = 0;
                    msg = "Введен некорректный возраст!";
                }

            }
        }
        public Person() { }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public static void SaveInFile(Person person)
        {
            string infoOfPerson = person.ToString();
            string filename = "InfoOfPerson.txt";
            File.WriteAllText(filename, infoOfPerson);
        }
        public static Person AskInfo(Person person)
        {
            Console.Write("Пожалуйста, введите свои данные\n\nФамилия: ");
            person.Surname = Console.ReadLine();
            Console.Write("\nИмя: ");
            person.Name = Console.ReadLine();
            Console.Write("\nВозраст: ");
            person.Age = Convert.ToInt32(Console.ReadLine());
            return person;
        }
        public override string ToString()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\nВозраст: {Age} {msg}";
        }
    }
}
