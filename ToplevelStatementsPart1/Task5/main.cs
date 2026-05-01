using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksCSharp.ToplevelStatementsPart1.Task5
{
    class Program
    {
        static void Main()
        {
            Journal journal = new Journal();

            journal.InputData();
            journal.PrintData();

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\nНазва журналу: " + journal.GetName());

            journal.SetName("Updated Journal Name");
            Console.WriteLine("Нова назва: " + journal.GetName());
        }
    }
}
