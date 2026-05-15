using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksCSharp.Interfaces.IOutput2
{
    using System;

    public class Array : IOutput2
    {
        private int[] data;

        public Array(int[] values)
        {
            data = values;
        }

        public void ShowEven()
        {
            Console.WriteLine("Even numbers:");
            foreach (var item in data)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd numbers:");
            foreach (var item in data)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }

}
