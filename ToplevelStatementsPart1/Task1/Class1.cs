//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HomeworksCSharp.ToplevelStatementsPart1.Task1
//{

//    class Program
//    {
//        static void DrawSquare(int side, char symbol)
//        {
//            for (int i = 0; i < side; i++)
//            {
//                for (int j = 0; j < side; j++)
//                {
//                    Console.Write(symbol);
//                }
//                Console.WriteLine();
//            }
//        }

//        static void Main()
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Console.Write("Введіть довжину сторони: ");
//            string input = Console.ReadLine();

//            if (int.TryParse(input, out int side) && side > 0)
//            {
//                Console.Write("Введіть символ: ");
//                char symbol = Console.ReadKey().KeyChar;
//                Console.WriteLine(); 

//                DrawSquare(side, symbol);
//            }
//            else
//            {
//                Console.WriteLine("Помилка: введіть коректне додатнє число!");
//            }
//        }
//    }
//}
