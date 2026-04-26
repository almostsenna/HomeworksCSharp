//namespace HomeworksCSharp
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            int number;
//            Console.Write("Введіть число: ");

//            if (!int.TryParse(Console.ReadLine(), out number))
//            {
//                Console.WriteLine("Помилка: введіть коректне число!"); // тут кириллиця норамльно працює, юхууу
//            }
//            else if (number < 1 || number > 100)
//            {
//                Console.WriteLine("Помилка: число має бути від 1 до 100!");
//            }
//            else
//            {
//                RunFizzBuzz(number);
//            }

//            static void RunFizzBuzz(int number)
//            {
//                for (int i = 1; i <= number; i++)
//                {
//                    if (i % 3 == 0 && i % 5 == 0)
//                        Console.WriteLine("FizzBuzz");
//                    else if (i % 3 == 0)
//                        Console.WriteLine("Fizz");
//                    else if (i % 5 == 0)
//                        Console.WriteLine("Buzz");
//                    else
//                        Console.WriteLine(i);
//                }
//            }
//        }
//    }
//}