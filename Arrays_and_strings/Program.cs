//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        int[,] array = new int[5, 5];
//        Random rand = new Random();

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                array[i, j] = rand.Next(-100, 101);
//                Console.Write($"{array[i, j],5}");
//            }
//            Console.WriteLine();
//        }

//        int min = array[0, 0], max = array[0, 0];
//        int minIndex = 0, maxIndex = 0;
//        int index = 0;

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                if (array[i, j] < min)
//                {
//                    min = array[i, j];
//                    minIndex = index;
//                }
//                if (array[i, j] > max)
//                {
//                    max = array[i, j];
//                    maxIndex = index;
//                }
//                index++;
//            }
//        }

//        int start, end;
//        if (minIndex < maxIndex)
//        {
//            start = minIndex;
//            end = maxIndex;
//        }
//        else
//        {
//            start = maxIndex;
//            end = minIndex;
//        }
//        int sum = 0;
//        index = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                if (index > start && index < end)
//                {
//                    sum += array[i, j];
//                }
//                index++;
//            }
//        }

//        Console.WriteLine($"\nМінімальний елемент: {min}");
//        Console.WriteLine($"Максимальний елемент: {max}");
//        Console.WriteLine($"Сума елементів між ними: {sum}");
//    }
//}
