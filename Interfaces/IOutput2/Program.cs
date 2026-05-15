using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksCSharp.Interfaces.IOutput2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array array = new Array(numbers);

            array.ShowEven(); 
            array.ShowOdd();  
        }
    }
}
