using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksCSharp.Task3
{
    internal class Task3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть першу цифру: ");
            int d1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть другу цифру: ");
            int d2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть третю цифру: ");
            int d3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть четверту цифру: ");
            int d4 = Convert.ToInt32(Console.ReadLine());

            string numberStr = $"{d1}{d2}{d3}{d4}";
            int result = Convert.ToInt32(numberStr);

            Console.WriteLine($"Сформоване число: {result}");
        }
    }
}
