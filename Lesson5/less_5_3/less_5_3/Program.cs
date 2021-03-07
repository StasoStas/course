using System;
using System.IO;

namespace less_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любые числа от 0 до 255, разделяя их пробелом:");
            string[] stringArr = Console.ReadLine().Split(new char[] { ' ' });
            byte[] byteArr = new byte[stringArr.Length];

            for (int i = 0; i < stringArr.Length - 1; i++)
            {
                byteArr[i] += Convert.ToByte(stringArr[i]);
            }

            File.WriteAllBytes("bytes.bin", byteArr);
        }
    }
}
