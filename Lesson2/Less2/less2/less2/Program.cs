using System;

namespace less2
{
    class Program
    {
        static void Main(string[] args)
        {



            #region firstProg

            Console.WriteLine("Програма 1 : Cреднесуточная температура");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Максимальная температура за сутку : ");
            double maxTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Минимальная температура за сутку : ");
            double minTemp = Convert.ToDouble(Console.ReadLine());

            double middTemp = (maxTemp + minTemp) / 2;

            Console.WriteLine($"Среднесуточная температура за сутку : {middTemp}");
            Console.ReadLine();
            Console.Clear();
            #endregion


            #region secondProg

            Console.WriteLine("Програма 2 : Месяца");
            Console.WriteLine("-------------------");

            int currentMonthNumber = 1;

            Console.Write("Введите порядковый номер текущего месяца: ");
            currentMonthNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Текущий месяц - {(Months)currentMonthNumber}");
            Console.ReadLine();
            Console.Clear();
            #endregion


            #region thirdProg

            Console.WriteLine("Програма 3 : Четное число");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Введите число :");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Четное число");
            }
            else
            {
                Console.WriteLine("Не четное число");
            }

            Console.ReadLine();
            Console.Clear();

            #endregion


            #region fourProg

            Console.WriteLine("Програма 4 : Чек");
            Console.WriteLine("----------------");

            string name = "OOO Компания";
            DateTime dateNow = new DateTime(2021, 02, 19, 19, 12, 3);
            int resul = 1900;
            long FH = 87100000100243210;

            Console.WriteLine($"\tДобро Пожаловать\n\t{name}");
            Console.WriteLine($"\tКасса №3 смена №118 \n\t{dateNow}");
            Console.WriteLine($"\nСапоги \t\t\t {resul}");
            Console.WriteLine($"Итого \t\t\t {resul}");
            Console.WriteLine($"ФН \t{FH}");
            Console.WriteLine($"\tСпасибо!");

            Console.ReadLine();

            #endregion
        }

        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
