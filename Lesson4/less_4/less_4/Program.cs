using System;

namespace less_4
{
    class Program
    {

        // Ex_1
        //static void Main(string[] args)
        //{
        //    GetFullName("Stanislav", "Staso", "Makaev");
        //    GetFullName("Tania", "Staso", "Banditov");
        //    GetFullName("Yura", "Staso", "Valeriev");
        //    GetFullName("Vlad", "Staso", "Krytoj");
        //}

        //static string GetFullName(string firstName, string lastName, string patronymic) 
        //{

        //    string fullName = firstName + " " + lastName + " " + patronymic;

        //    Console.WriteLine(fullName);

        //    return fullName;
        //}


        ///////////////
        //static void Main(string[] args)
        //{
        //    int totalSum;

        //    Console.Write("Введите любое кол-во целых чисел через пробел: ");
        //    string numbersString = Console.ReadLine();

        //    totalSum = SumFromString(numbersString);
        //    Console.WriteLine($"Сумма всех ввденных чисел: {totalSum}");

        //    Console.ReadLine();
        //}

        ///// <summary>
        ///// Метод разделяет строку чисел на массив подстрок и после конвертации складывает их
        ///// </summary>
        ///// <param name="str">Строка чисел разделенных пробелом</param>
        ///// <returns></returns>
        //static int SumFromString(string str)
        //{
        //    int sum = 0;
        //    string[] strNumbers = str.Split(new char[] { ' ' });

        //    for (int i = 0; i < strNumbers.Length; i++)
        //    {
        //        sum += Convert.ToInt32(strNumbers[i]);
        //    }
        //    return sum;
        //}


        ////////////////////


        static void Main(string[] args)
        {
            SeasonEnum season = SeasonEnum.Error;
            string seasonRus = String.Empty;

            do
            {
                Console.Clear();
                if (season == SeasonEnum.Error) Console.WriteLine(seasonRus);
                Console.Write("Введите порядковый номер текущего месяца: ");
                int monthNumber = Convert.ToInt32(Console.ReadLine());

                (season, seasonRus) = GetSeason(monthNumber);

            } while (season == SeasonEnum.Error);

            Console.WriteLine($"На дворе {seasonRus}");

            Console.ReadLine();
        }

        /// <summary>
        /// Метод - два в одном
        /// </summary>
        /// <param name="month">Порядковый номер месяца</param>
        /// <returns>season - значение из перечисления, msg - время года</returns>
        static (SeasonEnum, string) GetSeason(int month)
        {
            SeasonEnum season = SeasonEnum.Error;
            string msg = "Ошибка: введите число от 1 до 12";
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = SeasonEnum.Winter;
                    msg = "Зима";
                    return (season, msg);
                case 3:
                case 4:
                case 5:
                    season = SeasonEnum.Spring;
                    msg = "Весна";
                    return (season, msg);
                case 6:
                case 7:
                case 8:
                    season = SeasonEnum.Summer;
                    msg = "Лето";
                    return (season, msg);
                case 9:
                case 10:
                case 11:
                    season = SeasonEnum.Autumn;
                    msg = "Осень";
                    return (season, msg);
            }
            return (season, msg);
        }
        enum SeasonEnum
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            Error
        }

    }
}
